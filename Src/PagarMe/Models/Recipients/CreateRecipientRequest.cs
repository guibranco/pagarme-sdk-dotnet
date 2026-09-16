using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to create a recipient.
/// </summary>
public class CreateRecipientRequest
{
    /// <summary>
    /// The registration (KYC) data. Required.
    /// </summary>
    public RegisterInformation? RegisterInformation { get; set; }

    /// <summary>
    /// The bank account transfers are sent to. Required.
    /// </summary>
    public BankAccountRequest? DefaultBankAccount { get; set; }

    /// <summary>
    /// Automatic transfer settings.
    /// </summary>
    public TransferSettings? TransferSettings { get; set; }

    /// <summary>
    /// Automatic anticipation settings.
    /// </summary>
    public AutomaticAnticipationSettings? AutomaticAnticipationSettings { get; set; }

    /// <summary>
    /// Your own unique reference for the recipient.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// A description of the recipient.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
