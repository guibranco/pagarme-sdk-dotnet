using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A managing partner of a corporation recipient.
/// </summary>
public class ManagingPartner
{
    /// <summary>
    /// Full name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// E-mail address.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Document number (CPF), digits only.
    /// </summary>
    public string? Document { get; set; }

    /// <summary>
    /// The partner type (<c>individual</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Mother name.
    /// </summary>
    public string? MotherName { get; set; }

    /// <summary>
    /// Date of birth in <c>dd/mm/yyyy</c> format.
    /// </summary>
    public string? Birthdate { get; set; }

    /// <summary>
    /// Monthly income in cents.
    /// </summary>
    public string? MonthlyIncome { get; set; }

    /// <summary>
    /// Professional occupation.
    /// </summary>
    public string? ProfessionalOccupation { get; set; }

    /// <summary>
    /// Whether the partner is the self-declared legal representative.
    /// </summary>
    public bool? SelfDeclaredLegalRepresentative { get; set; }

    /// <summary>
    /// Address.
    /// </summary>
    public RegisterInformationAddress? Address { get; set; }

    /// <summary>
    /// Phone numbers.
    /// </summary>
    public List<RegisterInformationPhone>? PhoneNumbers { get; set; }
}
