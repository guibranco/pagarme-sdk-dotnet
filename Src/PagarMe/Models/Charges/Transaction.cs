using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A transaction attempted for a <see cref="Charge" />. The populated fields depend on
/// <see cref="TransactionType" />: card transactions expose acquirer data and the card, boleto transactions
/// expose the URL, line and barcode, Pix transactions expose the QR code.
/// </summary>
public class Transaction
{
    /// <summary>
    /// The transaction identifier (<c>tran_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The transaction type (<c>credit_card</c>, <c>debit_card</c>, <c>boleto</c>, <c>pix</c>...).
    /// </summary>
    public string? TransactionType { get; set; }

    /// <summary>
    /// The gateway identifier.
    /// </summary>
    public string? GatewayId { get; set; }

    /// <summary>
    /// Amount in cents.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Amount paid in cents, for boletos.
    /// </summary>
    public int? PaidAmount { get; set; }

    /// <summary>
    /// The transaction status. See <see cref="TransactionStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Whether the transaction succeeded.
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// Number of installments.
    /// </summary>
    public int? Installments { get; set; }

    /// <summary>
    /// Text shown on the card statement.
    /// </summary>
    public string? StatementDescriptor { get; set; }

    /// <summary>
    /// The operation type. See <see cref="OperationTypes" />.
    /// </summary>
    public string? OperationType { get; set; }

    /// <summary>
    /// The card funding source (<c>credit</c>, <c>debit</c>, <c>prepaid</c>).
    /// </summary>
    public string? FundingSource { get; set; }

    /// <summary>
    /// The acquirer name.
    /// </summary>
    public string? AcquirerName { get; set; }

    /// <summary>
    /// The acquirer transaction identifier.
    /// </summary>
    public string? AcquirerTid { get; set; }

    /// <summary>
    /// The acquirer NSU.
    /// </summary>
    public string? AcquirerNsu { get; set; }

    /// <summary>
    /// The authorization code returned by the acquirer.
    /// </summary>
    public string? AcquirerAuthCode { get; set; }

    /// <summary>
    /// The message returned by the acquirer.
    /// </summary>
    public string? AcquirerMessage { get; set; }

    /// <summary>
    /// The return code of the acquirer (<c>00</c> means approved).
    /// </summary>
    public string? AcquirerReturnCode { get; set; }

    /// <summary>
    /// The card used, for card transactions.
    /// </summary>
    public Card? Card { get; set; }

    /// <summary>
    /// The boleto URL (HTML), for boleto transactions.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// The boleto PDF URL, for boleto transactions.
    /// </summary>
    public string? Pdf { get; set; }

    /// <summary>
    /// The boleto typeable line, for boleto transactions.
    /// </summary>
    public string? Line { get; set; }

    /// <summary>
    /// The boleto barcode, for boleto transactions.
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// The bank "nosso número", for boleto transactions.
    /// </summary>
    public string? NossoNumero { get; set; }

    /// <summary>
    /// The bank code, for boleto transactions.
    /// </summary>
    public string? Bank { get; set; }

    /// <summary>
    /// Your document number, for boleto transactions.
    /// </summary>
    public string? DocumentNumber { get; set; }

    /// <summary>
    /// The instructions printed on the boleto.
    /// </summary>
    public string? Instructions { get; set; }

    /// <summary>
    /// The boleto type.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The due date, for boleto transactions.
    /// </summary>
    public DateTimeOffset? DueAt { get; set; }

    /// <summary>
    /// The Pix QR code payload (copy and paste), for Pix transactions. Also present on boleto transactions
    /// that offer Pix.
    /// </summary>
    public string? QrCode { get; set; }

    /// <summary>
    /// The Pix QR code image URL, for Pix transactions.
    /// </summary>
    public string? QrCodeUrl { get; set; }

    /// <summary>
    /// When the Pix QR code expires.
    /// </summary>
    public DateTimeOffset? ExpiresAt { get; set; }

    /// <summary>
    /// The Pix end-to-end identifier, once paid.
    /// </summary>
    public string? EndToEndId { get; set; }

    /// <summary>
    /// The Pix payer, once paid.
    /// </summary>
    public PixPayer? Payer { get; set; }

    /// <summary>
    /// The raw gateway response.
    /// </summary>
    public GatewayResponse? GatewayResponse { get; set; }

    /// <summary>
    /// The antifraud analysis result, when available.
    /// </summary>
    public AntifraudResponse? AntifraudResponse { get; set; }

    /// <summary>
    /// The split rules applied to the transaction.
    /// </summary>
    public List<Split>? Split { get; set; }

    /// <summary>
    /// When the transaction was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the transaction was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
