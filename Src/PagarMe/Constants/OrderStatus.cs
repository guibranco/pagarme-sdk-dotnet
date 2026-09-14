namespace PagarMe.Models;

/// <summary>
/// Possible values of <see cref="Order.Status" />.
/// </summary>
public static class OrderStatus
{
    /// <summary>Waiting for payment.</summary>
    public const string Pending = "pending";

    /// <summary>Fully paid.</summary>
    public const string Paid = "paid";

    /// <summary>Canceled.</summary>
    public const string Canceled = "canceled";

    /// <summary>Payment failed.</summary>
    public const string Failed = "failed";
}
