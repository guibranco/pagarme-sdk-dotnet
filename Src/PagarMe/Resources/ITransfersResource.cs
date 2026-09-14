using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Transfers of funds from a recipient balance to its bank account.
/// </summary>
public interface ITransfersResource
{
    /// <summary>
    /// Creates a transfer. <c>POST /transfers</c>.
    /// </summary>
    /// <param name="request">The transfer to create.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created transfer.</returns>
    Task<Transfer> CreateAsync(
        CreateTransferRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a transfer. <c>GET /transfers/{transfer_id}</c>.
    /// </summary>
    /// <param name="transferId">The transfer identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The transfer.</returns>
    Task<Transfer> GetAsync(string transferId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists transfers. This endpoint returns a plain array and uses cursor paging. <c>GET /transfers</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The transfers.</returns>
    Task<List<Transfer>> ListAsync(
        ListTransfersRequest? request = null,
        CancellationToken cancellationToken = default
    );
}
