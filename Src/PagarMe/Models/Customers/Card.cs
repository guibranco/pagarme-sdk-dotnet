using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A card stored on a customer, as returned by the API. Only the first six and last four digits are exposed.
/// </summary>
public class Card
{
    /// <summary>
    /// The card identifier (<c>card_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The first six digits of the card number.
    /// </summary>
    public string? FirstSixDigits { get; set; }

    /// <summary>
    /// The last four digits of the card number.
    /// </summary>
    public string? LastFourDigits { get; set; }

    /// <summary>
    /// The card brand (for example <c>Visa</c>).
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// The holder name as printed on the card.
    /// </summary>
    public string? HolderName { get; set; }

    /// <summary>
    /// The holder document (CPF/CNPJ).
    /// </summary>
    public string? HolderDocument { get; set; }

    /// <summary>
    /// Expiration month (1-12).
    /// </summary>
    public int? ExpMonth { get; set; }

    /// <summary>
    /// Expiration year.
    /// </summary>
    public int? ExpYear { get; set; }

    /// <summary>
    /// The card status (<c>active</c>, <c>deleted</c> or <c>expired</c>).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The card type (<c>credit</c>, <c>debit</c> or <c>voucher</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// A label to identify the card.
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// When the card was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the card was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// The billing address.
    /// </summary>
    public Address? BillingAddress { get; set; }

    /// <summary>
    /// The customer that owns the card.
    /// </summary>
    public Customer? Customer { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
