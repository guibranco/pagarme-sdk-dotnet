namespace PagarMe.Models;

/// <summary>
/// Possible values of <see cref="Charge.Status" />.
/// </summary>
public static class ChargeStatus
{
    /// <summary>Waiting for payment.</summary>
    public const string Pending = "pending";

    /// <summary>Paid.</summary>
    public const string Paid = "paid";

    /// <summary>Canceled or refunded.</summary>
    public const string Canceled = "canceled";

    /// <summary>Being processed by the acquirer.</summary>
    public const string Processing = "processing";

    /// <summary>Payment failed.</summary>
    public const string Failed = "failed";

    /// <summary>Paid with an amount greater than requested (boleto).</summary>
    public const string Overpaid = "overpaid";

    /// <summary>Paid with an amount lower than requested (boleto).</summary>
    public const string Underpaid = "underpaid";

    /// <summary>A chargeback was received.</summary>
    public const string Chargedback = "chargedback";
}
