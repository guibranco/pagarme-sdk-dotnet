using System;

namespace PagarMe.Models;

/// <summary>
/// Shipping information sent when creating an order.
/// </summary>
public class ShippingRequest
{
    /// <summary>
    /// Shipping cost in cents. Required.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Description of the shipping method. Required.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Name of the person receiving the goods. Required.
    /// </summary>
    public string? RecipientName { get; set; }

    /// <summary>
    /// Phone of the person receiving the goods. Required.
    /// </summary>
    public string? RecipientPhone { get; set; }

    /// <summary>
    /// The delivery address. Required.
    /// </summary>
    public AddressRequest? Address { get; set; }

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
