namespace PagarMe.Models;

/// <summary>
/// Options accepted when canceling a subscription.
/// </summary>
public class CancelSubscriptionRequest
{
    /// <summary>
    /// Whether pending invoices are canceled together with the subscription. Defaults to <see langword="true" />.
    /// </summary>
    public bool? CancelPendingInvoices { get; set; }
}
