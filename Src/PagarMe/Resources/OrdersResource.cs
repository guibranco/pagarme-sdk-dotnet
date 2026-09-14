using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="IOrdersResource" />
internal sealed class OrdersResource : IOrdersResource
{
    private const string BasePath = "orders";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrdersResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public OrdersResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Order> CreateAsync(
        CreateOrderRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Order>(BasePath, request, options, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Order> GetAsync(string orderId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(orderId, nameof(orderId));
        return _connection.GetAsync<Order>(ApiPath.Join(BasePath, orderId), null, cancellationToken);
    }

    /// <inheritdoc />
    public Task<PagedResponse<Order>> ListAsync(
        ListOrdersRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Order>>(BasePath, request, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Order> CloseAsync(string orderId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(orderId, nameof(orderId));
        return _connection.PatchAsync<Order>(
            ApiPath.Join(BasePath, orderId, "closed"),
            new { status = "closed" },
            cancellationToken
        );
    }
}
