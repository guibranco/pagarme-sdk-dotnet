namespace PagarMe.Models;

/// <summary>
/// Request to manually change the status of an invoice.
/// </summary>
public class UpdateInvoiceStatusRequest
{
    /// <summary>
    /// The new status (<c>pending</c>, <c>paid</c> or <c>canceled</c>). Required.
    /// </summary>
    public string? Status { get; set; }
}
