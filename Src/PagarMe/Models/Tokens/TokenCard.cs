namespace PagarMe.Models;

/// <summary>
/// Masked card information attached to a <see cref="Token" />.
/// </summary>
public class TokenCard
{
    /// <summary>
    /// The first six digits of the card number, when returned.
    /// </summary>
    public string? FirstSixDigits { get; set; }

    /// <summary>
    /// The last four digits of the card number.
    /// </summary>
    public string? LastFourDigits { get; set; }

    /// <summary>
    /// The holder name.
    /// </summary>
    public string? HolderName { get; set; }

    /// <summary>
    /// The holder document, when informed.
    /// </summary>
    public string? HolderDocument { get; set; }

    /// <summary>
    /// Expiration month (1-12).
    /// </summary>
    public int? ExpMonth { get; set; }

    /// <summary>
    /// Expiration year.
    /// </summary>
    public int? ExpYear { get; set; }

    /// <summary>
    /// The card brand.
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// The card label.
    /// </summary>
    public string? Label { get; set; }
}
