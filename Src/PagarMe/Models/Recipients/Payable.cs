using System;

namespace PagarMe.Models;

/// <summary>
/// A payable: a single installment of a charge that will be (or was) settled to a recipient.
/// </summary>
public class Payable
{
    /// <summary>
    /// The payable identifier.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The payable status (<c>waiting_funds</c>, <c>paid</c>, <c>prepaid</c>...).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Gross amount in cents.
    /// </summary>
    public long? Amount { get; set; }

    /// <summary>
    /// Processing fee in cents.
    /// </summary>
    public long? Fee { get; set; }

    /// <summary>
    /// Anticipation fee in cents.
    /// </summary>
    public long? AnticipationFee { get; set; }

    /// <summary>
    /// Fraud coverage fee in cents.
    /// </summary>
    public long? FraudCoverageFee { get; set; }

    /// <summary>
    /// The installment number.
    /// </summary>
    public int? Installment { get; set; }

    /// <summary>
    /// The gateway identifier.
    /// </summary>
    public string? GatewayId { get; set; }

    /// <summary>
    /// The charge the payable belongs to.
    /// </summary>
    public string? ChargeId { get; set; }

    /// <summary>
    /// The recipient receiving the payable.
    /// </summary>
    public string? RecipientId { get; set; }

    /// <summary>
    /// The split rule that originated the payable, if any.
    /// </summary>
    public string? SplitId { get; set; }

    /// <summary>
    /// When the payable is (or was) settled.
    /// </summary>
    public DateTimeOffset? PaymentDate { get; set; }

    /// <summary>
    /// The original settlement date, before anticipation.
    /// </summary>
    public DateTimeOffset? OriginalPaymentDate { get; set; }

    /// <summary>
    /// The payable type (<c>credit</c>, <c>refund</c>, <c>chargeback</c>...).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The payment method of the charge.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// When the payable accrued.
    /// </summary>
    public DateTimeOffset? AccrualAt { get; set; }

    /// <summary>
    /// When the payable was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }
}
