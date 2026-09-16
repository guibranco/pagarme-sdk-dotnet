using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing plans.
/// </summary>
public class ListPlansRequest : ListRequest
{
    /// <summary>
    /// Filter by name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Filter by status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Filter by billing type. See <see cref="BillingTypes" />.
    /// </summary>
    public string? BillingType { get; set; }

    /// <summary>
    /// Only plans created at or after this moment.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; set; }

    /// <summary>
    /// Only plans created at or before this moment.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; set; }
}
