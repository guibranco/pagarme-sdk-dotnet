using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Card data sent to the API: when storing a card on a customer, tokenizing a card or paying an order with
/// a card that is not stored yet. Never log instances of this class.
/// </summary>
public class CardRequest
{
    /// <summary>
    /// The card number, 13 to 19 digits. Required unless <see cref="Token" /> is used.
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// The holder name as printed on the card. Max 64 characters. Required.
    /// </summary>
    public string? HolderName { get; set; }

    /// <summary>
    /// The holder document (CPF/CNPJ). Required for voucher cards.
    /// </summary>
    public string? HolderDocument { get; set; }

    /// <summary>
    /// Expiration month (1-12). Required.
    /// </summary>
    public int? ExpMonth { get; set; }

    /// <summary>
    /// Expiration year, two or four digits. Required.
    /// </summary>
    public int? ExpYear { get; set; }

    /// <summary>
    /// The security code, 3 or 4 digits.
    /// </summary>
    public string? Cvv { get; set; }

    /// <summary>
    /// The card brand (for example <c>visa</c>, <c>mastercard</c>, <c>elo</c>).
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// A label to identify the card.
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// The identifier of an existing customer address to use as billing address.
    /// </summary>
    public string? BillingAddressId { get; set; }

    /// <summary>
    /// The billing address, when not referencing an existing one.
    /// </summary>
    public AddressRequest? BillingAddress { get; set; }

    /// <summary>
    /// A card token (<c>token_...</c>) created through the tokens endpoint, used instead of the raw card data.
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    /// Processing options.
    /// </summary>
    public CardOptions? Options { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
