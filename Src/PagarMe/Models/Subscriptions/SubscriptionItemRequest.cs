namespace PagarMe.Models;

/// <summary>
/// An item sent when creating a standalone subscription.
/// </summary>
public class SubscriptionItemRequest
{
    /// <summary>
    /// The item identifier, when referencing an existing item.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The item name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The item description. Required.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Quantity. Required for unit schemes.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// Number of cycles the item is billed for. Omit to bill every cycle.
    /// </summary>
    public int? Cycles { get; set; }

    /// <summary>
    /// The pricing scheme. Required.
    /// </summary>
    public PricingScheme? PricingScheme { get; set; }
}
