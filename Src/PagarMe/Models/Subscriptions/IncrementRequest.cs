namespace PagarMe.Models;

/// <summary>
/// An increment sent when creating a subscription.
/// </summary>
public class IncrementRequest
{
    /// <summary>
    /// The increment value: cents when <see cref="IncrementType" /> is <c>flat</c>, otherwise a percentage. Required.
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// The increment type (<c>flat</c> or <c>percentage</c>). Required.
    /// </summary>
    public string? IncrementType { get; set; }

    /// <summary>
    /// Number of cycles the increment applies to. Omit to apply to every cycle.
    /// </summary>
    public int? Cycles { get; set; }

    /// <summary>
    /// The subscription item the increment applies to.
    /// </summary>
    public string? ItemId { get; set; }

    /// <summary>
    /// A description of the increment.
    /// </summary>
    public string? Description { get; set; }
}
