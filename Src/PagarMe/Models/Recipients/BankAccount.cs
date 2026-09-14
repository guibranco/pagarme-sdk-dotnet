using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A bank account of a <see cref="Recipient" />.
/// </summary>
public class BankAccount
{
    /// <summary>
    /// The bank account identifier (<c>ba_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The account holder name.
    /// </summary>
    public string? HolderName { get; set; }

    /// <summary>
    /// The holder type (<c>individual</c> or <c>company</c>).
    /// </summary>
    public string? HolderType { get; set; }

    /// <summary>
    /// The holder document (CPF/CNPJ).
    /// </summary>
    public string? HolderDocument { get; set; }

    /// <summary>
    /// The bank code (3 digits).
    /// </summary>
    public string? Bank { get; set; }

    /// <summary>
    /// The branch number.
    /// </summary>
    public string? BranchNumber { get; set; }

    /// <summary>
    /// The branch check digit.
    /// </summary>
    public string? BranchCheckDigit { get; set; }

    /// <summary>
    /// The account number.
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// The account check digit.
    /// </summary>
    public string? AccountCheckDigit { get; set; }

    /// <summary>
    /// The account type (<c>checking</c> or <c>savings</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The bank account status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// When the bank account was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the bank account was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
