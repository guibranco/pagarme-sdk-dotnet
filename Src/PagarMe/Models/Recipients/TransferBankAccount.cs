using System;

namespace PagarMe.Models;

/// <summary>
/// The destination bank account of a <see cref="Transfer" />. Field names follow the transfers endpoint,
/// which differs from <see cref="BankAccount" />.
/// </summary>
public class TransferBankAccount
{
    /// <summary>
    /// The bank account identifier.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The bank code.
    /// </summary>
    public string? BankCode { get; set; }

    /// <summary>
    /// The branch number.
    /// </summary>
    public string? Agencia { get; set; }

    /// <summary>
    /// The branch check digit.
    /// </summary>
    public string? AgenciaDv { get; set; }

    /// <summary>
    /// The account number.
    /// </summary>
    public string? Conta { get; set; }

    /// <summary>
    /// The account check digit.
    /// </summary>
    public string? ContaDv { get; set; }

    /// <summary>
    /// The account type (for example <c>conta_corrente</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The holder document type.
    /// </summary>
    public string? DocumentType { get; set; }

    /// <summary>
    /// The holder document number.
    /// </summary>
    public string? DocumentNumber { get; set; }

    /// <summary>
    /// The holder legal name.
    /// </summary>
    public string? LegalName { get; set; }

    /// <summary>
    /// Whether transfer fees are charged to this account.
    /// </summary>
    public bool? ChargeTransferFees { get; set; }

    /// <summary>
    /// When the bank account was created.
    /// </summary>
    public DateTimeOffset? DateCreated { get; set; }
}
