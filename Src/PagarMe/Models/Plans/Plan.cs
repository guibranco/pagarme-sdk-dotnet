using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A plan: a template describing what and how often subscriptions are billed.
/// </summary>
public class Plan
{
    /// <summary>
    /// The plan identifier (<c>plan_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The plan name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The plan description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The relative URL of the plan.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Whether the plan involves shipping.
    /// </summary>
    public bool? Shippable { get; set; }

    /// <summary>
    /// The accepted payment methods. See <see cref="PaymentMethods" />.
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
    /// Text shown on the card statement.
    /// </summary>
    public string? StatementDescriptor { get; set; }

    /// <summary>
    /// Currency code.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// The recurrence interval. See <see cref="PlanIntervals" />.
    /// </summary>
    public string? Interval { get; set; }

    /// <summary>
    /// Number of intervals between charges.
    /// </summary>
    public int? IntervalCount { get; set; }

    /// <summary>
    /// The billing type. See <see cref="BillingTypes" />.
    /// </summary>
    public string? BillingType { get; set; }

    /// <summary>
    /// The allowed billing days when <see cref="BillingType" /> is <c>exact_day</c>.
    /// </summary>
    public List<int>? BillingDays { get; set; }

    /// <summary>
    /// Number of trial days.
    /// </summary>
    public int? TrialPeriodDays { get; set; }

    /// <summary>
    /// The plan status (<c>active</c>, <c>inactive</c> or <c>deleted</c>).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The reason of the current status, when any.
    /// </summary>
    public string? StatusReason { get; set; }

    /// <summary>
    /// The pricing scheme of the plan itself, when not using items.
    /// </summary>
    public PricingScheme? PricingScheme { get; set; }

    /// <summary>
    /// The plan items.
    /// </summary>
    public List<PlanItem>? Items { get; set; }

    /// <summary>
    /// When the plan was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the plan was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
