namespace PagarMe.Models;

/// <summary>
/// An address in the registration data of a recipient.
/// </summary>
public class RegisterInformationAddress
{
    /// <summary>
    /// Street name.
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Complement.
    /// </summary>
    public string? Complementary { get; set; }

    /// <summary>
    /// Street number.
    /// </summary>
    public string? StreetNumber { get; set; }

    /// <summary>
    /// Neighbourhood.
    /// </summary>
    public string? Neighborhood { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State (two letters).
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Postal code, digits only.
    /// </summary>
    public string? ZipCode { get; set; }

    /// <summary>
    /// Reference point.
    /// </summary>
    public string? ReferencePoint { get; set; }
}
