namespace PagarMe.Models;

/// <summary>
/// Request to tokenize a card. The token is short lived and lets your front end avoid sending raw card data
/// to your servers.
/// </summary>
public class CreateTokenRequest
{
    /// <summary>
    /// The token type. Only <c>card</c> is supported.
    /// </summary>
    public string Type { get; set; } = "card";

    /// <summary>
    /// The card to tokenize. Required.
    /// </summary>
    public CardRequest? Card { get; set; }
}
