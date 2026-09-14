namespace PagarMe.Models;

/// <summary>
/// A quantity bracket of a volume or tiered <see cref="PricingScheme" />.
/// </summary>
public class PriceBracket
{
    /// <summary>
    /// The first quantity of the bracket.
    /// </summary>
    public int? StartQuantity { get; set; }

    /// <summary>
    /// The last quantity of the bracket. <see langword="null" /> means unbounded.
    /// </summary>
    public int? EndQuantity { get; set; }

    /// <summary>
    /// Price in cents.
    /// </summary>
    public int? Price { get; set; }

    /// <summary>
    /// Price in cents of each unit above <see cref="EndQuantity" />.
    /// </summary>
    public int? OveragePrice { get; set; }
}
