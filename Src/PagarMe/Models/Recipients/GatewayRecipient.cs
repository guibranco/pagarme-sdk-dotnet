using System;
using Newtonsoft.Json;

namespace PagarMe.Models;

/// <summary>
/// The registration of a <see cref="Recipient" /> on a gateway.
/// </summary>
public class GatewayRecipient
{
    /// <summary>
    /// The gateway name.
    /// </summary>
    public string? Gateway { get; set; }

    /// <summary>
    /// The registration status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The recipient identifier on the gateway.
    /// </summary>
    public string? Pgid { get; set; }

    /// <summary>
    /// When the registration was created.
    /// </summary>
    [JsonProperty("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the registration was last updated.
    /// </summary>
    [JsonProperty("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; set; }
}
