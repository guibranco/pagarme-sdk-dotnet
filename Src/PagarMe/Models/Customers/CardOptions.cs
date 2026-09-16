namespace PagarMe.Models;

/// <summary>
/// Processing options applied when a card is stored.
/// </summary>
public class CardOptions
{
    /// <summary>
    /// When <see langword="true" /> the card is validated with a zero-dollar authorization before being stored.
    /// </summary>
    public bool? VerifyCard { get; set; }
}
