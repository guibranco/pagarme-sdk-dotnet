using System;

namespace PagarMe.Models;

/// <summary>
/// Request to change when the next invoice of a subscription is issued.
/// </summary>
public class UpdateSubscriptionBillingDateRequest
{
    /// <summary>
    /// The new billing date. Required.
    /// </summary>
    public DateTimeOffset? NextBillingAt { get; set; }
}
