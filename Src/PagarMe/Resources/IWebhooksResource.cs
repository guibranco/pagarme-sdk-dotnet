using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Inspection and redelivery of webhooks sent by Pagar.me. To parse an incoming webhook request use
/// <see cref="WebhookEvent.Parse" />.
/// </summary>
public interface IWebhooksResource
{
    /// <summary>
    /// Retrieves a webhook delivery. <c>GET /hooks/{hook_id}</c>.
    /// </summary>
    /// <param name="hookId">The webhook identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The webhook.</returns>
    Task<Webhook> GetAsync(string hookId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists webhook deliveries. <c>GET /hooks</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of webhooks.</returns>
    Task<PagedResponse<Webhook>> ListAsync(
        ListWebhooksRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Re-sends a webhook to your endpoint. <c>POST /hooks/{hook_id}/retry</c>.
    /// </summary>
    /// <param name="hookId">The webhook identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The webhook after the retry.</returns>
    Task<Webhook> RetryAsync(string hookId, CancellationToken cancellationToken = default);
}
