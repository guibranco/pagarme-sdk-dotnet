using System;

namespace PagarMe.Models;

/// <summary>
/// A discount applied to a <see cref="Subscription" />.
/// </summary>
public class Discount
{
    /// <summary>
    /// The discount identifier (<c>dis_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The discount value: cents when <see cref="DiscountType" /> is <c>flat</c>, otherwise a percentage.
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// The discount type (<c>flat</c> or <c>percentage</c>).
    /// </summary>
    public string? DiscountType { get; set; }

    /// <summary>
    /// Number of cycles the discount applies to. <see langword="null" /> means every cycle.
    /// </summary>
    public int? Cycles { get; set; }

    /// <summary>
    /// The discount status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// A description of the discount.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// When the discount was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }
}
