namespace PagarMe.Models;

/// <summary>
/// A discount sent when creating a subscription.
/// </summary>
public class DiscountRequest
{
    /// <summary>
    /// The discount value: cents when <see cref="DiscountType" /> is <c>flat</c>, otherwise a percentage. Required.
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// The discount type (<c>flat</c> or <c>percentage</c>). Required.
    /// </summary>
    public string? DiscountType { get; set; }

    /// <summary>
    /// Number of cycles the discount applies to. Omit to apply to every cycle.
    /// </summary>
    public int? Cycles { get; set; }

    /// <summary>
    /// The subscription item the discount applies to.
    /// </summary>
    public string? ItemId { get; set; }

    /// <summary>
    /// A description of the discount.
    /// </summary>
    public string? Description { get; set; }
}
