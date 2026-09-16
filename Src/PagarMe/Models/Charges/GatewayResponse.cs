using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// The raw response of the gateway for a <see cref="Transaction" />.
/// </summary>
public class GatewayResponse
{
    /// <summary>
    /// The gateway response code.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// The errors reported by the gateway, if any.
    /// </summary>
    public List<GatewayError>? Errors { get; set; }
}
