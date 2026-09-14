namespace PagarMe.Models;

/// <summary>
/// A phone number split into its numeric parts.
/// </summary>
public class Phone
{
    /// <summary>
    /// Country code, digits only (for example <c>55</c>).
    /// </summary>
    public string? CountryCode { get; set; }

    /// <summary>
    /// Area code, digits only (for example <c>11</c>).
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// Subscriber number, digits only.
    /// </summary>
    public string? Number { get; set; }
}
