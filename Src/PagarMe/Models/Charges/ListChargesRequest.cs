using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing charges.
/// </summary>
public class ListChargesRequest : ListRequest
{
    /// <summary>
    /// Filter by your own reference.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Filter by status. See <see cref="ChargeStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Filter by payment method. See <see cref="PaymentMethods" />.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Filter by customer identifier.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Filter by order identifier.
    /// </summary>
    public string? OrderId { get; set; }

    /// <summary>
    /// Only charges created at or after this moment.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; set; }

    /// <summary>
    /// Only charges created at or before this moment.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; set; }
}
