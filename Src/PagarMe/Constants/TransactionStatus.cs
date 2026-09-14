namespace PagarMe.Models;

/// <summary>
/// Common values of <see cref="Transaction.Status" />. The API may return additional values.
/// </summary>
public static class TransactionStatus
{
    /// <summary>Authorized and waiting for capture.</summary>
    public const string AuthorizedPendingCapture = "authorized_pending_capture";

    /// <summary>The acquirer declined the transaction.</summary>
    public const string NotAuthorized = "not_authorized";

    /// <summary>Captured.</summary>
    public const string Captured = "captured";

    /// <summary>Partially captured.</summary>
    public const string PartialCapture = "partial_capture";

    /// <summary>Waiting for capture.</summary>
    public const string WaitingCapture = "waiting_capture";

    /// <summary>Refunded.</summary>
    public const string Refunded = "refunded";

    /// <summary>Voided before capture.</summary>
    public const string Voided = "voided";

    /// <summary>Partially refunded.</summary>
    public const string PartialRefunded = "partial_refunded";

    /// <summary>Partially voided.</summary>
    public const string PartialVoid = "partial_void";

    /// <summary>A generic processing error occurred.</summary>
    public const string WithError = "with_error";

    /// <summary>Failed.</summary>
    public const string Failed = "failed";

    /// <summary>Boleto or Pix generated and waiting for payment.</summary>
    public const string Generated = "generated";

    /// <summary>Boleto was viewed by the customer.</summary>
    public const string Viewed = "viewed";

    /// <summary>Waiting for payment.</summary>
    public const string WaitingPayment = "waiting_payment";

    /// <summary>Paid.</summary>
    public const string Paid = "paid";

    /// <summary>Paid below the expected amount.</summary>
    public const string Underpaid = "underpaid";

    /// <summary>Paid above the expected amount.</summary>
    public const string Overpaid = "overpaid";

    /// <summary>Refund requested and pending.</summary>
    public const string PendingRefund = "pending_refund";
}
