using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PagarMe.Http;

/// <summary>
/// Convenience helpers so resources can express calls as one-liners.
/// </summary>
internal static class ApiConnectionExtensions
{
    /// <summary>
    /// The <c>PATCH</c> method, which is not exposed by <see cref="HttpMethod" /> on .NET Standard 2.0.
    /// </summary>
    public static readonly HttpMethod Patch = new("PATCH");

    /// <summary>
    /// Sends a <c>GET</c> request.
    /// </summary>
    public static Task<T> GetAsync<T>(
        this IApiConnection connection,
        string path,
        object? query,
        CancellationToken cancellationToken
    )
    {
        return connection.SendAsync<T>(
            new ApiRequest(HttpMethod.Get, path) { Query = query },
            cancellationToken
        );
    }

    /// <summary>
    /// Sends a <c>POST</c> request with an optional JSON body.
    /// </summary>
    public static Task<T> PostAsync<T>(
        this IApiConnection connection,
        string path,
        object? body,
        RequestOptions? options,
        CancellationToken cancellationToken
    )
    {
        return connection.SendAsync<T>(
            new ApiRequest(HttpMethod.Post, path) { Body = body, Options = options },
            cancellationToken
        );
    }

    /// <summary>
    /// Sends a <c>PUT</c> request with a JSON body.
    /// </summary>
    public static Task<T> PutAsync<T>(
        this IApiConnection connection,
        string path,
        object? body,
        CancellationToken cancellationToken
    )
    {
        return connection.SendAsync<T>(
            new ApiRequest(HttpMethod.Put, path) { Body = body },
            cancellationToken
        );
    }

    /// <summary>
    /// Sends a <c>PATCH</c> request with a JSON body.
    /// </summary>
    public static Task<T> PatchAsync<T>(
        this IApiConnection connection,
        string path,
        object? body,
        CancellationToken cancellationToken
    )
    {
        return connection.SendAsync<T>(
            new ApiRequest(Patch, path) { Body = body },
            cancellationToken
        );
    }

    /// <summary>
    /// Sends a <c>DELETE</c> request with an optional JSON body.
    /// </summary>
    public static Task<T> DeleteAsync<T>(
        this IApiConnection connection,
        string path,
        object? body,
        RequestOptions? options,
        CancellationToken cancellationToken
    )
    {
        return connection.SendAsync<T>(
            new ApiRequest(HttpMethod.Delete, path) { Body = body, Options = options },
            cancellationToken
        );
    }
}
