namespace PagarMe.Models;

/// <summary>
/// An item sent when creating an order.
/// </summary>
public class OrderItemRequest
{
    /// <summary>
    /// Unit price in cents. Required.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Description of the item. Required.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Quantity. Required.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// Your own reference for the item. Max 52 characters.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// The item category.
    /// </summary>
    public string? Category { get; set; }
}
