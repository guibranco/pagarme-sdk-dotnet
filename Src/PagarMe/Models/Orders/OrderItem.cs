using System;

namespace PagarMe.Models;

/// <summary>
/// An item of an <see cref="Order" />.
/// </summary>
public class OrderItem
{
    /// <summary>
    /// The item identifier (<c>oi_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The item type (<c>product</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Description of the item.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Unit price in cents.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Quantity.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// The item status (<c>active</c> or <c>deleted</c>).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Your own reference for the item.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// The item category.
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// When the item was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the item was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }
}
