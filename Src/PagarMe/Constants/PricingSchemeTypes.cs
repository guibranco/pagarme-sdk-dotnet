namespace PagarMe.Models;

/// <summary>
/// Pricing scheme types for plan and subscription items.
/// </summary>
public static class PricingSchemeTypes
{
    /// <summary>A fixed price per unit.</summary>
    public const string Unit = "unit";

    /// <summary>A fixed price per package of units.</summary>
    public const string Package = "package";

    /// <summary>Price per unit depends on the total quantity.</summary>
    public const string Volume = "volume";

    /// <summary>Price per unit is tiered by quantity brackets.</summary>
    public const string Tier = "tier";
}
