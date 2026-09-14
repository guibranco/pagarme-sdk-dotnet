using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to create a plan.
/// </summary>
public class CreatePlanRequest
{
    /// <summary>
    /// The plan name. Max 64 characters. Required.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The plan description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Whether the plan involves shipping.
    /// </summary>
    public bool? Shippable { get; set; }

    /// <summary>
    /// The accepted payment methods. See <see cref="PaymentMethods" />. Defaults to credit card.
    /// </summary>
    public List<string>? PaymentMethods { get; set; }

    /// <summary>
    /// The allowed installment counts.
    /// </summary>
    public List<int>? Installments { get; set; }

    /// <summary>
    /// Minimum invoice amount in cents.
    /// </summary>
    public int? MinimumPrice { get; set; }

    /// <summary>
    /// Text shown on the card statement. Max 13 characters.
    /// </summary>
    public string? StatementDescriptor { get; set; }

    /// <summary>
    /// Currency code. Defaults to <c>BRL</c>.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// The recurrence interval. See <see cref="PlanIntervals" />. Defaults to month.
    /// </summary>
    public string? Interval { get; set; }

    /// <summary>
    /// Number of intervals between charges. Defaults to 1.
    /// </summary>
    public int? IntervalCount { get; set; }

    /// <summary>
    /// The billing type. See <see cref="BillingTypes" />.
    /// </summary>
    public string? BillingType { get; set; }

    /// <summary>
    /// The allowed billing days (1-28). Required when <see cref="BillingType" /> is <c>exact_day</c>.
    /// </summary>
    public List<int>? BillingDays { get; set; }

    /// <summary>
    /// Number of trial days.
    /// </summary>
    public int? TrialPeriodDays { get; set; }

    /// <summary>
    /// The pricing scheme of the plan itself, when not using items.
    /// </summary>
    public PricingScheme? PricingScheme { get; set; }

    /// <summary>
    /// Quantity, required when <see cref="PricingScheme" /> is a unit scheme.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// The plan items.
    /// </summary>
    public List<PlanItemRequest>? Items { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
