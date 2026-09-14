using System.Net.Http;

namespace PagarMe.Http;

/// <summary>
/// Describes a single call to the API before it is turned into an <see cref="HttpRequestMessage" />.
/// </summary>
internal sealed class ApiRequest
{
    /// <summary>
    /// Initializes a new request.
    /// </summary>
    /// <param name="method">The HTTP method.</param>
    /// <param name="path">The path relative to the API base URL, for example <c>orders/or_123</c>.</param>
    public ApiRequest(HttpMethod method, string path)
    {
        Method = method;
        Path = path;
    }

    /// <summary>
    /// The HTTP method.
    /// </summary>
    public HttpMethod Method { get; }

    /// <summary>
    /// The path relative to the API base URL. Must not start with a slash.
    /// </summary>
    public string Path { get; }

    /// <summary>
    /// The object serialized as the JSON body, or <see langword="null" /> for no body.
    /// </summary>
    public object? Body { get; set; }

    /// <summary>
    /// The object whose public properties become query string parameters, or <see langword="null" />.
    /// </summary>
    public object? Query { get; set; }

    /// <summary>
    /// Optional per-request options supplied by the caller.
    /// </summary>
    public RequestOptions? Options { get; set; }

    /// <summary>
    /// Whether the <c>Authorization</c> header must be sent. The card token endpoint is the only one that
    /// rejects it.
    /// </summary>
    public bool Authenticate { get; set; } = true;
}
