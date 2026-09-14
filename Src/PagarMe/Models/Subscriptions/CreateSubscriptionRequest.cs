using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to create a subscription, either from a plan (<see cref="PlanId" />) or standalone (fill the
/// interval, billing type and items yourself).
/// </summary>
public class CreateSubscriptionRequest
{
    /// <summary>
    /// The plan identifier, for plan based subscriptions.
    /// </summary>
    public string? PlanId { get; set; }

    /// <summary>
    /// The identifier of an existing customer. Use either this or <see cref="Customer" />.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Inline customer data.
    /// </summary>
    public CustomerRequest? Customer { get; set; }

    /// <summary>
    /// The payment method. See <see cref="PaymentMethods" />. Required.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// The identifier of a card stored on the customer.
    /// </summary>
    public string? CardId { get; set; }

    /// <summary>
    /// Raw card data.
    /// </summary>
    public CardRequest? Card { get; set; }

    /// <summary>
    /// A card token created through the tokens endpoint.
    /// </summary>
    public string? CardToken { get; set; }

    /// <summary>
    /// Your own reference for the subscription.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Number of installments.
    /// </summary>
    public int? Installments { get; set; }

    /// <summary>
    /// Number of days before a boleto invoice is due.
    /// </summary>
    public int? BoletoDueDays { get; set; }

    /// <summary>
    /// When the subscription starts. Defaults to now.
    /// </summary>
    public DateTimeOffset? StartAt { get; set; }

    /// <summary>
    /// A description of the subscription.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Text shown on the card statement. Max 13 characters.
    /// </summary>
    public string? StatementDescriptor { get; set; }

    /// <summary>
    /// Currency code. Defaults to <c>BRL</c>.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// The recurrence interval, for standalone subscriptions. See <see cref="PlanIntervals" />.
    /// </summary>
    public string? Interval { get; set; }

    /// <summary>
    /// Number of intervals between charges, for standalone subscriptions.
    /// </summary>
    public int? IntervalCount { get; set; }

    /// <summary>
    /// The billing type, for standalone subscriptions. See <see cref="BillingTypes" />.
    /// </summary>
    public string? BillingType { get; set; }

    /// <summary>
    /// The billing day when <see cref="BillingType" /> is <c>exact_day</c>.
    /// </summary>
    public int? BillingDay { get; set; }

    /// <summary>
    /// Minimum invoice amount in cents.
    /// </summary>
    public int? MinimumPrice { get; set; }

    /// <summary>
    /// The pricing scheme of the subscription itself, when not using items.
    /// </summary>
    public PricingScheme? PricingScheme { get; set; }

    /// <summary>
    /// Quantity, required when <see cref="PricingScheme" /> is a unit scheme.
    /// </summary>
    public int? Quantity { get; set; }

    /// <summary>
    /// The subscription items, for standalone subscriptions.
    /// </summary>
    public List<SubscriptionItemRequest>? Items { get; set; }

    /// <summary>
    /// Discounts applied to the subscription.
    /// </summary>
    public List<DiscountRequest>? Discounts { get; set; }

    /// <summary>
    /// Increments applied to the subscription.
    /// </summary>
    public List<IncrementRequest>? Increments { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
