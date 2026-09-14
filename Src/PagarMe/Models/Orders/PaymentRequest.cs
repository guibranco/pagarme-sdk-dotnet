using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A payment sent when creating an order or a charge. Set <see cref="PaymentMethod" /> and fill the matching
/// payment object (<see cref="CreditCard" />, <see cref="DebitCard" />, <see cref="Boleto" /> or <see cref="Pix" />).
/// </summary>
public class PaymentRequest
{
    /// <summary>
    /// The payment method. See <see cref="PaymentMethods" />. Required.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Amount in cents. Required only when the order has more than one payment.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Credit card details, when <see cref="PaymentMethod" /> is <see cref="PaymentMethods.CreditCard" />.
    /// </summary>
    public CardPaymentRequest? CreditCard { get; set; }

    /// <summary>
    /// Debit card details, when <see cref="PaymentMethod" /> is <see cref="PaymentMethods.DebitCard" />.
    /// </summary>
    public CardPaymentRequest? DebitCard { get; set; }

    /// <summary>
    /// Boleto details, when <see cref="PaymentMethod" /> is <see cref="PaymentMethods.Boleto" />.
    /// </summary>
    public BoletoPaymentRequest? Boleto { get; set; }

    /// <summary>
    /// Pix details, when <see cref="PaymentMethod" /> is <see cref="PaymentMethods.Pix" />.
    /// </summary>
    public PixPaymentRequest? Pix { get; set; }

    /// <summary>
    /// Split rules distributing the amount between recipients.
    /// </summary>
    public List<SplitRequest>? Split { get; set; }
}
