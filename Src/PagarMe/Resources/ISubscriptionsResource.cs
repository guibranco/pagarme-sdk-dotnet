using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Operations on subscriptions.
/// </summary>
public interface ISubscriptionsResource
{
    /// <summary>
    /// Creates a subscription. <c>POST /subscriptions</c>.
    /// </summary>
    /// <param name="request">The subscription to create.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created subscription.</returns>
    Task<Subscription> CreateAsync(
        CreateSubscriptionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a subscription. <c>GET /subscriptions/{subscription_id}</c>.
    /// </summary>
    /// <param name="subscriptionId">The subscription identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The subscription.</returns>
    Task<Subscription> GetAsync(
        string subscriptionId,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists subscriptions. <c>GET /subscriptions</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of subscriptions.</returns>
    Task<PagedResponse<Subscription>> ListAsync(
        ListSubscriptionsRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancels a subscription. <c>DELETE /subscriptions/{subscription_id}</c>.
    /// </summary>
    /// <param name="subscriptionId">The subscription identifier.</param>
    /// <param name="request">Optional cancel details.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The canceled subscription.</returns>
    Task<Subscription> CancelAsync(
        string subscriptionId,
        CancelSubscriptionRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the card of a subscription. <c>PATCH /subscriptions/{subscription_id}/card</c>.
    /// </summary>
    /// <param name="subscriptionId">The subscription identifier.</param>
    /// <param name="request">The new card.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated subscription.</returns>
    Task<Subscription> UpdateCardAsync(
        string subscriptionId,
        UpdateSubscriptionCardRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes when the next invoice is issued. <c>PATCH /subscriptions/{subscription_id}/billing-date</c>.
    /// </summary>
    /// <param name="subscriptionId">The subscription identifier.</param>
    /// <param name="request">The new billing date.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated subscription.</returns>
    Task<Subscription> UpdateBillingDateAsync(
        string subscriptionId,
        UpdateSubscriptionBillingDateRequest request,
        CancellationToken cancellationToken = default
    );
}
