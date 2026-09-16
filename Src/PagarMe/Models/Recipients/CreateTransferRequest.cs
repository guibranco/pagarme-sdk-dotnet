using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to transfer funds from a recipient balance to its default bank account.
/// </summary>
public class CreateTransferRequest
{
    /// <summary>
    /// Amount in cents. Required.
    /// </summary>
    public long? Amount { get; set; }

    /// <summary>
    /// The recipient identifier. Defaults to the account main recipient.
    /// </summary>
    public string? RecipientId { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
