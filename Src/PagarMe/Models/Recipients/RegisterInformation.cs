using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Registration (KYC) data of a <see cref="Recipient" />. Fill the individual fields for
/// <c>individual</c> recipients and the company fields for <c>corporation</c> recipients.
/// Used both in requests and responses.
/// </summary>
public class RegisterInformation
{
    /// <summary>
    /// E-mail address. Required.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Document number (CPF/CNPJ), digits only. Required.
    /// </summary>
    public string? Document { get; set; }

    /// <summary>
    /// The recipient type (<c>individual</c> or <c>corporation</c>). Required.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The recipient web site.
    /// </summary>
    public string? SiteUrl { get; set; }

    /// <summary>
    /// Phone numbers. Required.
    /// </summary>
    public List<RegisterInformationPhone>? PhoneNumbers { get; set; }

    /// <summary>
    /// Full name, for individuals.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Mother name, for individuals.
    /// </summary>
    public string? MotherName { get; set; }

    /// <summary>
    /// Date of birth in <c>dd/mm/yyyy</c> format, for individuals.
    /// </summary>
    public string? Birthdate { get; set; }

    /// <summary>
    /// Monthly income in cents, for individuals.
    /// </summary>
    public string? MonthlyIncome { get; set; }

    /// <summary>
    /// Professional occupation, for individuals.
    /// </summary>
    public string? ProfessionalOccupation { get; set; }

    /// <summary>
    /// Address, for individuals.
    /// </summary>
    public RegisterInformationAddress? Address { get; set; }

    /// <summary>
    /// Company legal name, for corporations.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Company trading name, for corporations.
    /// </summary>
    public string? TradingName { get; set; }

    /// <summary>
    /// Annual revenue in cents, for corporations.
    /// </summary>
    public string? AnnualRevenue { get; set; }

    /// <summary>
    /// Corporation type (for example <c>ltda</c>, <c>sa</c>, <c>mei</c>), for corporations.
    /// </summary>
    public string? CorporationType { get; set; }

    /// <summary>
    /// Founding date in <c>dd/mm/yyyy</c> format, for corporations.
    /// </summary>
    public string? FoundingDate { get; set; }

    /// <summary>
    /// CNAE code, for corporations.
    /// </summary>
    public string? Cnae { get; set; }

    /// <summary>
    /// Main address, for corporations.
    /// </summary>
    public RegisterInformationAddress? MainAddress { get; set; }

    /// <summary>
    /// Managing partners, for corporations.
    /// </summary>
    public List<ManagingPartner>? ManagingPartners { get; set; }
}
