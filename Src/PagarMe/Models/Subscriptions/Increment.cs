using System;

namespace PagarMe.Models;

/// <summary>
/// An increment applied to a <see cref="Subscription" />.
/// </summary>
public class Increment
{
    /// <summary>
    /// The increment identifier (<c>inc_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The increment value: cents when <see cref="IncrementType" /> is <c>flat</c>, otherwise a percentage.
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// The increment type (<c>flat</c> or <c>percentage</c>).
    /// </summary>
    public string? IncrementType { get; set; }

    /// <summary>
    /// Number of cycles the increment applies to. <see langword="null" /> means every cycle.
    /// </summary>
    public int? Cycles { get; set; }

    /// <summary>
    /// The increment status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// A description of the increment.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// When the increment was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }
}
