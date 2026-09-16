using System;

namespace PagarMe.Models;

/// <summary>
/// A billing cycle of a <see cref="Subscription" />.
/// </summary>
public class SubscriptionCycle
{
    /// <summary>
    /// The cycle identifier (<c>cycle_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// When the cycle starts.
    /// </summary>
    public DateTimeOffset? StartAt { get; set; }

    /// <summary>
    /// When the cycle ends.
    /// </summary>
    public DateTimeOffset? EndAt { get; set; }

    /// <summary>
    /// When the cycle is billed.
    /// </summary>
    public DateTimeOffset? BillingAt { get; set; }

    /// <summary>
    /// The cycle status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The cycle number.
    /// </summary>
    public int? Cycle { get; set; }

    /// <summary>
    /// When the cycle was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the cycle was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }
}
