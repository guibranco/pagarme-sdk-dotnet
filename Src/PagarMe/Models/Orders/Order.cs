using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// An order: the transaction container that groups items, the customer and one or more charges.
/// </summary>
public class Order
{
    /// <summary>
    /// The order identifier (<c>or_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Your own reference for the order.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Total amount in cents.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Currency code (<c>BRL</c>).
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// Whether the order is closed. Closed orders no longer accept charges.
    /// </summary>
    public bool? Closed { get; set; }

    /// <summary>
    /// The items of the order.
    /// </summary>
    public List<OrderItem>? Items { get; set; }

    /// <summary>
    /// The customer.
    /// </summary>
    public Customer? Customer { get; set; }

    /// <summary>
    /// The order status. See <see cref="OrderStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// When the order was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the order was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// When the order was closed.
    /// </summary>
    public DateTimeOffset? ClosedAt { get; set; }

    /// <summary>
    /// The charges created for the order. Inspect each charge status to know whether the payment succeeded.
    /// </summary>
    public List<Charge>? Charges { get; set; }

    /// <summary>
    /// Shipping information.
    /// </summary>
    public Shipping? Shipping { get; set; }

    /// <summary>
    /// The IP address of the buyer, when informed.
    /// </summary>
    public string? Ip { get; set; }

    /// <summary>
    /// The antifraud session identifier, when informed.
    /// </summary>
    public string? SessionId { get; set; }

    /// <summary>
    /// The buyer location, when informed.
    /// </summary>
    public Location? Location { get; set; }

    /// <summary>
    /// The buyer device, when informed.
    /// </summary>
    public Device? Device { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
