using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Bank account data sent when creating a recipient or refunding a charge.
/// </summary>
public class BankAccountRequest
{
    /// <summary>
    /// The account holder name. Required.
    /// </summary>
    public string? HolderName { get; set; }

    /// <summary>
    /// The holder type (<c>individual</c> or <c>company</c>). Required.
    /// </summary>
    public string? HolderType { get; set; }

    /// <summary>
    /// The holder document (CPF/CNPJ). Required.
    /// </summary>
    public string? HolderDocument { get; set; }

    /// <summary>
    /// The bank code (3 digits). Required.
    /// </summary>
    public string? Bank { get; set; }

    /// <summary>
    /// The branch number. Required.
    /// </summary>
    public string? BranchNumber { get; set; }

    /// <summary>
    /// The branch check digit.
    /// </summary>
    public string? BranchCheckDigit { get; set; }

    /// <summary>
    /// The account number. Required.
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// The account check digit. Required.
    /// </summary>
    public string? AccountCheckDigit { get; set; }

    /// <summary>
    /// The account type (<c>checking</c> or <c>savings</c>). Required.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
