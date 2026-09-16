namespace PagarMe.Models;

/// <summary>
/// Card payment details. Provide exactly one of <see cref="Card" />, <see cref="CardId" /> or <see cref="CardToken" />.
/// </summary>
public class CardPaymentRequest
{
    /// <summary>
    /// Number of installments (default 1).
    /// </summary>
    public int? Installments { get; set; }

    /// <summary>
    /// Text shown on the card statement. Max 13 characters.
    /// </summary>
    public string? StatementDescriptor { get; set; }

    /// <summary>
    /// The operation type. See <see cref="OperationTypes" />. Defaults to auth and capture.
    /// </summary>
    public string? OperationType { get; set; }

    /// <summary>
    /// Raw card data, when the card is not stored nor tokenized.
    /// </summary>
    public CardRequest? Card { get; set; }

    /// <summary>
    /// The identifier of a card stored on the customer.
    /// </summary>
    public string? CardId { get; set; }

    /// <summary>
    /// A card token created through the tokens endpoint.
    /// </summary>
    public string? CardToken { get; set; }

    /// <summary>
    /// Whether this is a recurring payment.
    /// </summary>
    public bool? Recurrence { get; set; }

    /// <summary>
    /// The recurrence cycle (<c>first</c> or <c>subsequent</c>) when <see cref="Recurrence" /> is set.
    /// </summary>
    public string? RecurrenceCycle { get; set; }
}
