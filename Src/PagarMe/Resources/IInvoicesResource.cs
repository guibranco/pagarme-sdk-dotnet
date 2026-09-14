using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Operations on subscription invoices.
/// </summary>
public interface IInvoicesResource
{
    /// <summary>
    /// Retrieves an invoice. <c>GET /invoices/{invoice_id}</c>.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The invoice.</returns>
    Task<Invoice> GetAsync(string invoiceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists invoices. <c>GET /invoices</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of invoices.</returns>
    Task<PagedResponse<Invoice>> ListAsync(
        ListInvoicesRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancels an invoice. <c>DELETE /invoices/{invoice_id}</c>.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The canceled invoice.</returns>
    Task<Invoice> CancelAsync(string invoiceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Manually changes the status of an invoice. <c>PATCH /invoices/{invoice_id}/status</c>.
    /// </summary>
    /// <param name="invoiceId">The invoice identifier.</param>
    /// <param name="request">The new status.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated invoice.</returns>
    Task<Invoice> UpdateStatusAsync(
        string invoiceId,
        UpdateInvoiceStatusRequest request,
        CancellationToken cancellationToken = default
    );
}
