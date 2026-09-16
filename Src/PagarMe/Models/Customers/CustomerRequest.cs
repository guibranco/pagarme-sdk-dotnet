using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Customer data sent when creating or updating a customer, or inline when creating an order or subscription.
/// </summary>
public class CustomerRequest
{
    /// <summary>
    /// Full name. Max 64 characters. Required.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// E-mail address. Max 64 characters. Required.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Your own reference for the customer. Max 52 characters.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Document number, digits only. Max 16 characters for CPF/CNPJ, 50 for passports.
    /// </summary>
    public string? Document { get; set; }

    /// <summary>
    /// Document type. See <see cref="DocumentTypes" />.
    /// </summary>
    public string? DocumentType { get; set; }

    /// <summary>
    /// Customer type. See <see cref="CustomerTypes" />. Required when a document is provided.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gender. See <see cref="Genders" />.
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// The default address.
    /// </summary>
    public AddressRequest? Address { get; set; }

    /// <summary>
    /// Phone numbers.
    /// </summary>
    public Phones? Phones { get; set; }

    /// <summary>
    /// Date of birth in <c>mm/dd/yyyy</c> format.
    /// </summary>
    public string? Birthdate { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
