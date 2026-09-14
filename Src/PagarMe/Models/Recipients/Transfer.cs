using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A transfer of funds from a recipient balance to its bank account.
/// </summary>
public class Transfer
{
    /// <summary>
    /// The transfer identifier.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Amount in cents.
    /// </summary>
    public long? Amount { get; set; }

    /// <summary>
    /// The transfer type (for example <c>ted</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The transfer status (<c>pending_transfer</c>, <c>transferred</c>, <c>failed</c>, <c>processing</c>,
    /// <c>canceled</c>).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The source type (<c>recipient</c>).
    /// </summary>
    public string? SourceType { get; set; }

    /// <summary>
    /// The source identifier (the recipient).
    /// </summary>
    public string? SourceId { get; set; }

    /// <summary>
    /// The target type (<c>bank_account</c>).
    /// </summary>
    public string? TargetType { get; set; }

    /// <summary>
    /// The target identifier (the bank account).
    /// </summary>
    public string? TargetId { get; set; }

    /// <summary>
    /// Fee charged in cents.
    /// </summary>
    public long? Fee { get; set; }

    /// <summary>
    /// When the funds reached the bank account.
    /// </summary>
    public DateTimeOffset? FundingDate { get; set; }

    /// <summary>
    /// When the funds are expected to reach the bank account.
    /// </summary>
    public DateTimeOffset? FundingEstimatedDate { get; set; }

    /// <summary>
    /// The related transaction identifier, if any.
    /// </summary>
    public string? TransactionId { get; set; }

    /// <summary>
    /// When the transfer was created.
    /// </summary>
    public DateTimeOffset? DateCreated { get; set; }

    /// <summary>
    /// When the transfer was last updated.
    /// </summary>
    public DateTimeOffset? DateUpdated { get; set; }

    /// <summary>
    /// The destination bank account.
    /// </summary>
    public TransferBankAccount? BankAccount { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
