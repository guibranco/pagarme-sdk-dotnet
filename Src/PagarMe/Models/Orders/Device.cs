namespace PagarMe.Models;

/// <summary>
/// Device information of the buyer, used by the antifraud analysis.
/// </summary>
public class Device
{
    /// <summary>
    /// The platform (for example <c>web</c>, <c>ios</c>, <c>android</c>).
    /// </summary>
    public string? Platform { get; set; }
}
