using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// How an item is priced. Used both in requests and responses.
/// </summary>
public class PricingScheme
{
    /// <summary>
    /// The scheme type. See <see cref="PricingSchemeTypes" />.
    /// </summary>
    public string? SchemeType { get; set; }

    /// <summary>
    /// Price in cents, for <c>unit</c> and <c>package</c> schemes.
    /// </summary>
    public int? Price { get; set; }

    /// <summary>
    /// Minimum price in cents.
    /// </summary>
    public int? MinimumPrice { get; set; }

    /// <summary>
    /// Quantity per package, for <c>package</c> schemes.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// Price brackets, for <c>volume</c> and <c>tier</c> schemes.
    /// </summary>
    public List<PriceBracket>? PriceBrackets { get; set; }
}
