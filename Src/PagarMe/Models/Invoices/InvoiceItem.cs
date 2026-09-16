namespace PagarMe.Models;

/// <summary>
/// An item of an <see cref="Invoice" />.
/// </summary>
public class InvoiceItem
{
    /// <summary>
    /// The item name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The item description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Amount in cents.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Quantity.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// The pricing scheme.
    /// </summary>
    public PricingScheme? PricingScheme { get; set; }

    /// <summary>
    /// The subscription item that originated this invoice item.
    /// </summary>
    public string? SubscriptionItemId { get; set; }
}
