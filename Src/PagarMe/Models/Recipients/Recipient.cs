using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A recipient: a party that receives part of the payments through split rules.
/// </summary>
public class Recipient
{
    /// <summary>
    /// The recipient identifier (<c>rp_...</c> or <c>re_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The recipient name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The recipient e-mail.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// A description of the recipient.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The recipient document (CPF/CNPJ).
    /// </summary>
    public string? Document { get; set; }

    /// <summary>
    /// The recipient type (<c>individual</c> or <c>corporation</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Your own reference for the recipient.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// The payment mode (<c>bank_transfer</c>).
    /// </summary>
    public string? PaymentMode { get; set; }

    /// <summary>
    /// The recipient status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// When the recipient was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the recipient was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// The bank account transfers are sent to.
    /// </summary>
    public BankAccount? DefaultBankAccount { get; set; }

    /// <summary>
    /// Automatic transfer settings.
    /// </summary>
    public TransferSettings? TransferSettings { get; set; }

    /// <summary>
    /// Automatic anticipation settings.
    /// </summary>
    public AutomaticAnticipationSettings? AutomaticAnticipationSettings { get; set; }

    /// <summary>
    /// The recipient registration on each gateway.
    /// </summary>
    public List<GatewayRecipient>? GatewayRecipients { get; set; }

    /// <summary>
    /// The registration data (KYC).
    /// </summary>
    public RegisterInformation? RegisterInformation { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
