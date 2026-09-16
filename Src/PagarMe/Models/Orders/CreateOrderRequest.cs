using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to create an order. This is the main way to charge a customer: the order carries the items, the
/// customer and one or more payments; the API creates a charge for each payment.
/// </summary>
public class CreateOrderRequest
{
    /// <summary>
    /// The items being sold. Required.
    /// </summary>
    public List<OrderItemRequest>? Items { get; set; }

    /// <summary>
    /// The identifier of an existing customer. Use either this or <see cref="Customer" />.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Inline customer data. The customer is created (or matched by <c>code</c>) together with the order.
    /// </summary>
    public CustomerRequest? Customer { get; set; }

    /// <summary>
    /// The payments. Required; usually a single payment covering the full amount.
    /// </summary>
    public List<PaymentRequest>? Payments { get; set; }

    /// <summary>
    /// Your own reference for the order. Max 52 characters.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Whether the order is closed after creation (default <see langword="true" />). Open orders accept
    /// additional charges later.
    /// </summary>
    public bool? Closed { get; set; }

    /// <summary>
    /// Whether the antifraud analysis runs for this order.
    /// </summary>
    public bool? AntifraudEnabled { get; set; }

    /// <summary>
    /// Currency code. Defaults to <c>BRL</c>.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// Shipping information.
    /// </summary>
    public ShippingRequest? Shipping { get; set; }

    /// <summary>
    /// The IP address of the buyer.
    /// </summary>
    public string? Ip { get; set; }

    /// <summary>
    /// The antifraud session identifier.
    /// </summary>
    public string? SessionId { get; set; }

    /// <summary>
    /// The buyer location.
    /// </summary>
    public Location? Location { get; set; }

    /// <summary>
    /// The buyer device.
    /// </summary>
    public Device? Device { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
