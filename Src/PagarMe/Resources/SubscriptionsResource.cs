using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="ISubscriptionsResource" />
internal sealed class SubscriptionsResource : ISubscriptionsResource
{
    private const string BasePath = "subscriptions";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionsResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public SubscriptionsResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Subscription> CreateAsync(
        CreateSubscriptionRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Subscription>(BasePath, request, options, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Subscription> GetAsync(
        string subscriptionId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(subscriptionId, nameof(subscriptionId));
        return _connection.GetAsync<Subscription>(
            ApiPath.Join(BasePath, subscriptionId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Subscription>> ListAsync(
        ListSubscriptionsRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Subscription>>(
            BasePath,
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Subscription> CancelAsync(
        string subscriptionId,
        CancelSubscriptionRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(subscriptionId, nameof(subscriptionId));
        return _connection.DeleteAsync<Subscription>(
            ApiPath.Join(BasePath, subscriptionId),
            request,
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Subscription> UpdateCardAsync(
        string subscriptionId,
        UpdateSubscriptionCardRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(subscriptionId, nameof(subscriptionId));
        Guard.NotNull(request, nameof(request));
        return _connection.PatchAsync<Subscription>(
            ApiPath.Join(BasePath, subscriptionId, "card"),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Subscription> UpdateBillingDateAsync(
        string subscriptionId,
        UpdateSubscriptionBillingDateRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(subscriptionId, nameof(subscriptionId));
        Guard.NotNull(request, nameof(request));
        return _connection.PatchAsync<Subscription>(
            ApiPath.Join(BasePath, subscriptionId, "billing-date"),
            request,
            cancellationToken
        );
    }
}
