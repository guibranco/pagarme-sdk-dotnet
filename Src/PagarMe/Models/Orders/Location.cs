namespace PagarMe.Models;

/// <summary>
/// Geographic coordinates of the buyer, used by the antifraud analysis.
/// </summary>
public class Location
{
    /// <summary>
    /// Latitude.
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// Longitude.
    /// </summary>
    public string? Longitude { get; set; }
}
