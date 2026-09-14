using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Read access to payables (the settlement schedule of charges).
/// </summary>
public interface IPayablesResource
{
    /// <summary>
    /// Retrieves a payable. <c>GET /payables/{payable_id}</c>.
    /// </summary>
    /// <param name="payableId">The payable identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The payable.</returns>
    Task<Payable> GetAsync(string payableId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists payables. <c>GET /payables</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of payables.</returns>
    Task<PagedResponse<Payable>> ListAsync(
        ListPayablesRequest? request = null,
        CancellationToken cancellationToken = default
    );
}
