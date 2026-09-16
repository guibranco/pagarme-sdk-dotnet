using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PagarMe;

/// <summary>
/// Raised when the Pagar.me API answers with a non-successful HTTP status code.
/// Exposes the status code, the message returned by the API, the field-level validation errors and the raw body.
/// </summary>
public class PagarMeApiException : PagarMeException
{
    private static readonly IReadOnlyDictionary<string, IReadOnlyList<string>> NoErrors =
        new ReadOnlyDictionary<string, IReadOnlyList<string>>(
            new Dictionary<string, IReadOnlyList<string>>()
        );

    /// <summary>
    /// Initializes a new instance of the <see cref="PagarMeApiException" /> class.
    /// </summary>
    /// <param name="message">The exception message.</param>
    /// <param name="statusCode">The HTTP status code returned by the API.</param>
    /// <param name="errorMessage">The <c>message</c> field of the error payload, when present.</param>
    /// <param name="errors">The <c>errors</c> field of the error payload, when present.</param>
    /// <param name="responseBody">The raw response body.</param>
    /// <param name="requestMethod">The HTTP method of the request that failed.</param>
    /// <param name="requestPath">The relative path of the request that failed.</param>
    public PagarMeApiException(
        string message,
        HttpStatusCode statusCode,
        string? errorMessage,
        IReadOnlyDictionary<string, IReadOnlyList<string>>? errors,
        string? responseBody,
        string? requestMethod,
        string? requestPath
    )
        : base(message)
    {
        StatusCode = statusCode;
        ErrorMessage = errorMessage;
        Errors = errors ?? NoErrors;
        ResponseBody = responseBody;
        RequestMethod = requestMethod;
        RequestPath = requestPath;
    }

    /// <summary>
    /// The HTTP status code returned by the API.
    /// </summary>
    public HttpStatusCode StatusCode { get; }

    /// <summary>
    /// The human readable <c>message</c> returned by the API, if any.
    /// </summary>
    public string? ErrorMessage { get; }

    /// <summary>
    /// Field-level validation errors returned by the API, keyed by field path
    /// (for example <c>order.items[0].amount</c>). Empty when the API returned none.
    /// </summary>
    public IReadOnlyDictionary<string, IReadOnlyList<string>> Errors { get; }

    /// <summary>
    /// The raw response body, useful for logging and troubleshooting.
    /// </summary>
    public string? ResponseBody { get; }

    /// <summary>
    /// The HTTP method of the request that failed (for example <c>POST</c>).
    /// </summary>
    public string? RequestMethod { get; }

    /// <summary>
    /// The relative path of the request that failed (for example <c>orders</c>).
    /// </summary>
    public string? RequestPath { get; }

    /// <summary>
    /// <see langword="true" /> when the API rejected the credentials (HTTP 401).
    /// </summary>
    public bool IsAuthenticationError => StatusCode == HttpStatusCode.Unauthorized;

    /// <summary>
    /// <see langword="true" /> when the requested resource does not exist (HTTP 404).
    /// </summary>
    public bool IsNotFound => StatusCode == HttpStatusCode.NotFound;

    /// <summary>
    /// <see langword="true" /> when the request payload failed validation (HTTP 400 or 422).
    /// </summary>
    public bool IsValidationError =>
        StatusCode == HttpStatusCode.BadRequest || (int)StatusCode == 422;

    /// <summary>
    /// <see langword="true" /> when a business rule prevented the operation (HTTP 412).
    /// </summary>
    public bool IsPreconditionFailed => StatusCode == HttpStatusCode.PreconditionFailed;

    /// <summary>
    /// <see langword="true" /> when the account exceeded the API rate limit (HTTP 429).
    /// </summary>
    public bool IsRateLimited => (int)StatusCode == 429;

    /// <summary>
    /// <see langword="true" /> when the API failed internally (HTTP 5xx).
    /// </summary>
    public bool IsServerError => (int)StatusCode >= 500;

    /// <summary>
    /// Builds an exception from a failed HTTP response, parsing the standard
    /// <c>{ "message": "...", "errors": { "field": ["..."] } }</c> payload when present.
    /// </summary>
    /// <param name="method">The HTTP method of the request.</param>
    /// <param name="path">The relative path of the request.</param>
    /// <param name="statusCode">The status code of the response.</param>
    /// <param name="responseBody">The body of the response.</param>
    /// <returns>A populated <see cref="PagarMeApiException" />.</returns>
    public static PagarMeApiException FromResponse(
        HttpMethod method,
        string path,
        HttpStatusCode statusCode,
        string? responseBody
    )
    {
        string? errorMessage = null;
        var errors = new Dictionary<string, IReadOnlyList<string>>();

        if (!string.IsNullOrWhiteSpace(responseBody))
        {
            try
            {
                if (JToken.Parse(responseBody!) is JObject payload)
                {
                    errorMessage = payload.Value<string>("message");
                    ParseErrors(payload["errors"], errors);
                }
            }
            catch (JsonException)
            {
                // The body is not JSON (for example an HTML page from a proxy); keep the raw body only.
            }
        }

        var message = BuildMessage(method, path, statusCode, errorMessage, errors);

        return new PagarMeApiException(
            message,
            statusCode,
            errorMessage,
            new ReadOnlyDictionary<string, IReadOnlyList<string>>(errors),
            responseBody,
            method.Method,
            path
        );
    }

    private static void ParseErrors(
        JToken? token,
        IDictionary<string, IReadOnlyList<string>> target
    )
    {
        switch (token)
        {
            case JObject fields:
                foreach (var property in fields.Properties())
                {
                    target[property.Name] = ToMessages(property.Value);
                }
                break;
            case JArray list:
                target["errors"] = ToMessages(list);
                break;
        }
    }

    private static IReadOnlyList<string> ToMessages(JToken value)
    {
        return value is JArray array
            ? array.Select(item => item.ToString()).ToList()
            : new List<string> { value.ToString() };
    }

    private static string BuildMessage(
        HttpMethod method,
        string path,
        HttpStatusCode statusCode,
        string? errorMessage,
        IReadOnlyDictionary<string, IReadOnlyList<string>> errors
    )
    {
        var builder = new StringBuilder();
        builder
            .Append("Pagar.me API request '")
            .Append(method.Method)
            .Append(' ')
            .Append(path)
            .Append("' failed with status ")
            .Append((int)statusCode)
            .Append(" (")
            .Append(statusCode)
            .Append(')');

        if (!string.IsNullOrWhiteSpace(errorMessage))
        {
            builder.Append(": ").Append(errorMessage);
        }

        if (errors.Count > 0)
        {
            builder.Append(" [");
            builder.Append(
                string.Join(
                    "; ",
                    errors.Select(pair => pair.Key + ": " + string.Join(", ", pair.Value))
                )
            );
            builder.Append(']');
        }

        return builder.ToString();
    }
}
