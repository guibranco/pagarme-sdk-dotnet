namespace PagarMe.Models;

/// <summary>
/// Request to replace the card of a charge whose transaction was not authorized. Provide exactly one of
/// <see cref="CardId" />, <see cref="Card" /> or <see cref="CardToken" />.
/// </summary>
public class UpdateChargeCardRequest
{
    /// <summary>
    /// The identifier of a card stored on the customer.
    /// </summary>
    public string? CardId { get; set; }

    /// <summary>
    /// Raw card data.
    /// </summary>
    public CardRequest? Card { get; set; }

    /// <summary>
    /// A card token created through the tokens endpoint.
    /// </summary>
    public string? CardToken { get; set; }

    /// <summary>
    /// Whether the related subscription (if any) should also use the new card.
    /// </summary>
    public bool? UpdateSubscription { get; set; }
}
