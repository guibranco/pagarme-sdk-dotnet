using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="IWebhooksResource" />
internal sealed class WebhooksResource : IWebhooksResource
{
    private const string BasePath = "hooks";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="WebhooksResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public WebhooksResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Webhook> GetAsync(string hookId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(hookId, nameof(hookId));
        return _connection.GetAsync<Webhook>(ApiPath.Join(BasePath, hookId), null, cancellationToken);
    }

    /// <inheritdoc />
    public Task<PagedResponse<Webhook>> ListAsync(
        ListWebhooksRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Webhook>>(BasePath, request, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Webhook> RetryAsync(string hookId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(hookId, nameof(hookId));
        return _connection.PostAsync<Webhook>(
            ApiPath.Join(BasePath, hookId, "retry"),
            null,
            null,
            cancellationToken
        );
    }
}
