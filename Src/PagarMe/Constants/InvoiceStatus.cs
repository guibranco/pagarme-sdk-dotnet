namespace PagarMe.Models;

/// <summary>
/// Possible values of <see cref="Invoice.Status" />.
/// </summary>
public static class InvoiceStatus
{
    /// <summary>Waiting for payment.</summary>
    public const string Pending = "pending";

    /// <summary>Paid.</summary>
    public const string Paid = "paid";

    /// <summary>Canceled.</summary>
    public const string Canceled = "canceled";

    /// <summary>Scheduled to be charged.</summary>
    public const string Scheduled = "scheduled";

    /// <summary>Payment failed.</summary>
    public const string Failed = "failed";
}
