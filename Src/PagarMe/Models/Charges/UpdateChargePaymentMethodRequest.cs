namespace PagarMe.Models;

/// <summary>
/// Request to change the payment method of a pending charge.
/// </summary>
public class UpdateChargePaymentMethodRequest
{
    /// <summary>
    /// The new payment method. See <see cref="PaymentMethods" />. Required.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Credit card details, when switching to credit card.
    /// </summary>
    public CardPaymentRequest? CreditCard { get; set; }

    /// <summary>
    /// Debit card details, when switching to debit card.
    /// </summary>
    public CardPaymentRequest? DebitCard { get; set; }

    /// <summary>
    /// Boleto details, when switching to boleto.
    /// </summary>
    public BoletoPaymentRequest? Boleto { get; set; }

    /// <summary>
    /// Pix details, when switching to Pix.
    /// </summary>
    public PixPaymentRequest? Pix { get; set; }

    /// <summary>
    /// Whether the related subscription (if any) should also use the new payment method.
    /// </summary>
    public bool? UpdateSubscription { get; set; }

    /// <summary>
    /// Whether the existing split rules apply to the next transaction.
    /// </summary>
    public bool? ReuseSplit { get; set; }
}
