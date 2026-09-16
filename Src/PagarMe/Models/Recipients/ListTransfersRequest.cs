using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing transfers. This endpoint uses cursor paging instead of page numbers.
/// </summary>
public class ListTransfersRequest
{
    /// <summary>
    /// Number of results (max 1000, default 10).
    /// </summary>
    public int? Count { get; set; }

    /// <summary>
    /// The paging cursor returned by a previous call.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// Filter by transfer identifier.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Filter by recipient identifier.
    /// </summary>
    public string? RecipientId { get; set; }

    /// <summary>
    /// Filter by bank account identifier.
    /// </summary>
    public string? BankAccountId { get; set; }

    /// <summary>
    /// Filter by amount in cents.
    /// </summary>
    public long? Amount { get; set; }

    /// <summary>
    /// Filter by status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Filter by creation date.
    /// </summary>
    public DateTimeOffset? DateCreated { get; set; }

    /// <summary>
    /// Filter by last update date.
    /// </summary>
    public DateTimeOffset? DateUpdated { get; set; }
}
