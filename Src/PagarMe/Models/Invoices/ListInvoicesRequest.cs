using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing invoices.
/// </summary>
public class ListInvoicesRequest : ListRequest
{
    /// <summary>
    /// Filter by your own reference.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Filter by customer identifier.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Filter by subscription identifier.
    /// </summary>
    public string? SubscriptionId { get; set; }

    /// <summary>
    /// Filter by status. See <see cref="InvoiceStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Only invoices due at or after this moment.
    /// </summary>
    public DateTimeOffset? DueSince { get; set; }

    /// <summary>
    /// Only invoices due at or before this moment.
    /// </summary>
    public DateTimeOffset? DueUntil { get; set; }

    /// <summary>
    /// Only invoices created at or after this moment.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; set; }

    /// <summary>
    /// Only invoices created at or before this moment.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; set; }
}
