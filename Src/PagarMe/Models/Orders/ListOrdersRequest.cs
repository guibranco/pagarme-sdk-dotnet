using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing orders.
/// </summary>
public class ListOrdersRequest : ListRequest
{
    /// <summary>
    /// Filter by your own reference.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Filter by status. See <see cref="OrderStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Filter by customer identifier.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Only orders created at or after this moment.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; set; }

    /// <summary>
    /// Only orders created at or before this moment.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; set; }
}
