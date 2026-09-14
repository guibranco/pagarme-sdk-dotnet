using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A subscription: a recurring billing agreement with a customer.
/// </summary>
public class Subscription
{
    /// <summary>
    /// The subscription identifier (<c>sub_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Your own reference for the subscription.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// When the subscription starts.
    /// </summary>
    public DateTimeOffset? StartAt { get; set; }

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
    /// The billing day when <see cref="BillingType" /> is <c>exact_day</c>.
    /// </summary>
    public int? BillingDay { get; set; }

    /// <summary>
    /// The current billing cycle.
    /// </summary>
    public SubscriptionCycle? CurrentCycle { get; set; }

    /// <summary>
    /// When the next invoice is issued.
    /// </summary>
    public DateTimeOffset? NextBillingAt { get; set; }

    /// <summary>
    /// The payment method. See <see cref="PaymentMethods" />.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Currency code.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// Number of installments.
    /// </summary>
    public int? Installments { get; set; }

    /// <summary>
    /// Text shown on the card statement.
    /// </summary>
    public string? StatementDescriptor { get; set; }

    /// <summary>
    /// Minimum invoice amount in cents.
    /// </summary>
    public int? MinimumPrice { get; set; }

    /// <summary>
    /// Number of days before a boleto invoice is due.
    /// </summary>
    public int? BoletoDueDays { get; set; }

    /// <summary>
    /// The subscription status. See <see cref="SubscriptionStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// When the subscription was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the subscription was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// When the subscription was canceled.
    /// </summary>
    public DateTimeOffset? CanceledAt { get; set; }

    /// <summary>
    /// The customer.
    /// </summary>
    public Customer? Customer { get; set; }

    /// <summary>
    /// The card used for card subscriptions.
    /// </summary>
    public Card? Card { get; set; }

    /// <summary>
    /// The plan, for plan based subscriptions.
    /// </summary>
    public Plan? Plan { get; set; }

    /// <summary>
    /// The subscription items.
    /// </summary>
    public List<SubscriptionItem>? Items { get; set; }

    /// <summary>
    /// The discounts.
    /// </summary>
    public List<Discount>? Discounts { get; set; }

    /// <summary>
    /// The increments.
    /// </summary>
    public List<Increment>? Increments { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
