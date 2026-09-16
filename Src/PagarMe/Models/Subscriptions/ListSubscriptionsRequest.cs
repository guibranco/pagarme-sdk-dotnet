using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing subscriptions.
/// </summary>
public class ListSubscriptionsRequest : ListRequest
{
    /// <summary>
    /// Filter by your own reference.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Filter by billing type. See <see cref="BillingTypes" />.
    /// </summary>
    public string? BillingType { get; set; }

    /// <summary>
    /// Filter by customer identifier.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Filter by plan identifier.
    /// </summary>
    public string? PlanId { get; set; }

    /// <summary>
    /// Filter by card identifier.
    /// </summary>
    public string? CardId { get; set; }

    /// <summary>
    /// Filter by status. See <see cref="SubscriptionStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Only subscriptions whose next billing is at or after this moment.
    /// </summary>
    public DateTimeOffset? NextBillingSince { get; set; }

    /// <summary>
    /// Only subscriptions whose next billing is at or before this moment.
    /// </summary>
    public DateTimeOffset? NextBillingUntil { get; set; }

    /// <summary>
    /// Only subscriptions created at or after this moment.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; set; }

    /// <summary>
    /// Only subscriptions created at or before this moment.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; set; }
}
