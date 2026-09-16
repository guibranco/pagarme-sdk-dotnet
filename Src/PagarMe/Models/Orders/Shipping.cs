using System;

namespace PagarMe.Models;

/// <summary>
/// Shipping information of an <see cref="Order" />.
/// </summary>
public class Shipping
{
    /// <summary>
    /// Shipping cost in cents.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Description of the shipping method.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Name of the person receiving the goods.
    /// </summary>
    public string? RecipientName { get; set; }

    /// <summary>
    /// Phone of the person receiving the goods.
    /// </summary>
    public string? RecipientPhone { get; set; }

    /// <summary>
    /// The delivery address.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// The latest delivery date.
    /// </summary>
    public DateTimeOffset? MaxDeliveryDate { get; set; }

    /// <summary>
    /// The estimated delivery date.
    /// </summary>
    public DateTimeOffset? EstimatedDeliveryDate { get; set; }

    /// <summary>
    /// The shipping type.
    /// </summary>
    public string? Type { get; set; }
}
