namespace PagarMe.Models;

/// <summary>
/// Request to confirm that a cash charge was paid.
/// </summary>
public class ConfirmCashPaymentRequest
{
    /// <summary>
    /// Your own reference for the confirmation.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// A description of the payment.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Amount paid in cents.
    /// </summary>
    public int? Amount { get; set; }
}
