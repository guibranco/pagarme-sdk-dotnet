using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to update a recipient. Only registration fields that are still empty can be changed.
/// </summary>
public class UpdateRecipientRequest
{
    /// <summary>
    /// The registration (KYC) data.
    /// </summary>
    public RegisterInformation? RegisterInformation { get; set; }

    /// <summary>
    /// A description of the recipient.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
