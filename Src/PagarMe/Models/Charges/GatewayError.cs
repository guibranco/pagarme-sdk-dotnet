namespace PagarMe.Models;

/// <summary>
/// An error reported by the gateway.
/// </summary>
public class GatewayError
{
    /// <summary>
    /// The error message.
    /// </summary>
    public string? Message { get; set; }
}
