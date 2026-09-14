using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Operations on orders. An order is the transaction container: it holds the items, the customer and the
/// charges created for each payment.
/// </summary>
public interface IOrdersResource
{
    /// <summary>
    /// Creates an order and immediately attempts the payments it carries. <c>POST /orders</c>.
    /// </summary>
    /// <param name="request">The order to create.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created order, including its charges and their status.</returns>
    Task<Order> CreateAsync(
        CreateOrderRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves an order. <c>GET /orders/{order_id}</c>.
    /// </summary>
    /// <param name="orderId">The order identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The order.</returns>
    Task<Order> GetAsync(string orderId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists orders. <c>GET /orders</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of orders.</returns>
    Task<PagedResponse<Order>> ListAsync(
        ListOrdersRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Closes an open order so it no longer accepts charges. <c>PATCH /orders/{order_id}/closed</c>.
    /// </summary>
    /// <param name="orderId">The order identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The closed order.</returns>
    Task<Order> CloseAsync(string orderId, CancellationToken cancellationToken = default);
}
