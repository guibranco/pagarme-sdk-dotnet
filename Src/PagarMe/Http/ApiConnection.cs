using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PagarMe.Http;

/// <summary>
/// Default <see cref="IApiConnection" /> built on <see cref="HttpClient" />. Adds authentication, serializes
/// bodies, builds query strings and converts failed responses into <see cref="PagarMeApiException" />.
/// </summary>
internal sealed class ApiConnection : IApiConnection
{
    private const string JsonMediaType = "application/json";
    private const string IdempotencyHeader = "Idempotency-Key";

    private static readonly ProductInfoHeaderValue UserAgent = CreateUserAgent();

    private readonly HttpClient _httpClient;
    private readonly Uri _baseUri;
    private readonly AuthenticationHeaderValue _authorization;

    /// <summary>
    /// Initializes a new connection.
    /// </summary>
    /// <param name="httpClient">The client used to send requests. Its lifetime is managed by the caller.</param>
    /// <param name="options">The validated client options.</param>
    public ApiConnection(HttpClient httpClient, PagarMeClientOptions options)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        if (options == null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        _baseUri = options.GetBaseUri();
        _authorization = CreateBasicAuthorization(options.SecretKey);
    }

    /// <summary>
    /// Builds the <c>Authorization: Basic</c> header Pagar.me expects: the secret key as user name and an
    /// empty password.
    /// </summary>
    /// <param name="secretKey">The account secret key.</param>
    /// <returns>The header value.</returns>
    public static AuthenticationHeaderValue CreateBasicAuthorization(string secretKey)
    {
        var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(secretKey + ":"));
        return new AuthenticationHeaderValue("Basic", token);
    }

    /// <inheritdoc />
    public async Task<TResponse> SendAsync<TResponse>(
        ApiRequest request,
        CancellationToken cancellationToken
    )
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        using var message = BuildMessage(request);
        using var response = await SendCoreAsync(request, message, cancellationToken)
            .ConfigureAwait(false);

        var body =
            response.Content == null
                ? string.Empty
                : await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            throw PagarMeApiException.FromResponse(
                request.Method,
                request.Path,
                response.StatusCode,
                body
            );
        }

        if (string.IsNullOrWhiteSpace(body))
        {
            return default!;
        }

        try
        {
            return PagarMeJson.Deserialize<TResponse>(body)!;
        }
        catch (JsonException exception)
        {
            throw new PagarMeException(
                $"Unable to deserialize the response of '{request.Method.Method} {request.Path}' into {typeof(TResponse).Name}: {exception.Message}",
                exception
            );
        }
    }

    private async Task<HttpResponseMessage> SendCoreAsync(
        ApiRequest request,
        HttpRequestMessage message,
        CancellationToken cancellationToken
    )
    {
        try
        {
            return await _httpClient
                .SendAsync(message, HttpCompletionOption.ResponseContentRead, cancellationToken)
                .ConfigureAwait(false);
        }
        catch (HttpRequestException exception)
        {
            throw new PagarMeException(
                $"The request '{request.Method.Method} {request.Path}' could not be sent: {exception.Message}",
                exception
            );
        }
        catch (TaskCanceledException exception) when (!cancellationToken.IsCancellationRequested)
        {
            throw new PagarMeException(
                $"The request '{request.Method.Method} {request.Path}' timed out.",
                exception
            );
        }
    }

    private HttpRequestMessage BuildMessage(ApiRequest request)
    {
        var message = new HttpRequestMessage(request.Method, BuildUri(request));
        message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(JsonMediaType));
        message.Headers.UserAgent.Add(UserAgent);

        if (request.Authenticate)
        {
            message.Headers.Authorization = _authorization;
        }

        var idempotencyKey = request.Options?.IdempotencyKey;
        if (!string.IsNullOrWhiteSpace(idempotencyKey))
        {
            message.Headers.TryAddWithoutValidation(IdempotencyHeader, idempotencyKey);
        }

        if (request.Body != null)
        {
            message.Content = new StringContent(
                PagarMeJson.Serialize(request.Body),
                Encoding.UTF8,
                JsonMediaType
            );
        }

        return message;
    }

    private Uri BuildUri(ApiRequest request)
    {
        var path = request.Path.TrimStart('/');
        var query = QueryStringBuilder.Build(request.Query);
        var relative = query.Length == 0 ? path : path + "?" + query;
        return new Uri(_baseUri, relative);
    }

    private static ProductInfoHeaderValue CreateUserAgent()
    {
        var version =
            typeof(ApiConnection)
                .Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion
            ?? typeof(ApiConnection).Assembly.GetName().Version?.ToString()
            ?? "1.0.0";

        // Informational versions may carry a "+commit" suffix that is not a valid product token.
        var plus = version.IndexOf('+');
        if (plus >= 0)
        {
            version = version.Substring(0, plus);
        }

        return new ProductInfoHeaderValue("PagarMeSDK", version);
    }
}
