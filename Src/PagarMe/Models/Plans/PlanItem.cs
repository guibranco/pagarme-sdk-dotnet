using System;

namespace PagarMe.Models;

/// <summary>
/// An item of a <see cref="Plan" />.
/// </summary>
public class PlanItem
{
    /// <summary>
    /// The item identifier (<c>pi_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The item name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Quantity.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// Number of cycles the item is billed for. <see langword="null" /> means every cycle.
    /// </summary>
    public int? Cycles { get; set; }

    /// <summary>
    /// The item status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The pricing scheme.
    /// </summary>
    public PricingScheme? PricingScheme { get; set; }

    /// <summary>
    /// When the item was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the item was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }
}
