using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing payables.
/// </summary>
public class ListPayablesRequest : ListRequest
{
    /// <summary>
    /// Filter by payable identifier.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Filter by status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Filter by type.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Filter by charge identifier.
    /// </summary>
    public string? ChargeId { get; set; }

    /// <summary>
    /// Filter by recipient identifier.
    /// </summary>
    public string? RecipientId { get; set; }

    /// <summary>
    /// Filter by split rule identifier.
    /// </summary>
    public string? SplitId { get; set; }

    /// <summary>
    /// Only payables created at or after this moment.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; set; }

    /// <summary>
    /// Only payables created at or before this moment.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; set; }

    /// <summary>
    /// Only payables updated at or after this moment.
    /// </summary>
    public DateTimeOffset? UpdatedSince { get; set; }

    /// <summary>
    /// Only payables updated at or before this moment.
    /// </summary>
    public DateTimeOffset? UpdatedUntil { get; set; }

    /// <summary>
    /// Only payables settled at or after this moment.
    /// </summary>
    public DateTimeOffset? PaymentDateSince { get; set; }

    /// <summary>
    /// Only payables settled at or before this moment.
    /// </summary>
    public DateTimeOffset? PaymentDateUntil { get; set; }

    /// <summary>
    /// The forward cursor returned by a previous call, for cursor based paging.
    /// </summary>
    public string? ForwardCursor { get; set; }
}
