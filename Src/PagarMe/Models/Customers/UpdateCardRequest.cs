using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Fields that can be changed on a stored card. The card number cannot be updated.
/// </summary>
public class UpdateCardRequest
{
    /// <summary>
    /// The holder name as printed on the card. Max 64 characters.
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
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
