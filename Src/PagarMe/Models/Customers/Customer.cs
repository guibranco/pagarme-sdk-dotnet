using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A customer as returned by the API.
/// </summary>
public class Customer
{
    /// <summary>
    /// The customer identifier (<c>cus_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Full name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// E-mail address.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Your own reference for the customer.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Document number (CPF, CNPJ or passport), digits only.
    /// </summary>
    public string? Document { get; set; }

    /// <summary>
    /// Document type. See <see cref="DocumentTypes" />.
    /// </summary>
    public string? DocumentType { get; set; }

    /// <summary>
    /// Customer type. See <see cref="CustomerTypes" />.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gender. See <see cref="Genders" />.
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// Whether the customer has overdue payments.
    /// </summary>
    public bool? Delinquent { get; set; }

    /// <summary>
    /// The default address.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// Date of birth.
    /// </summary>
    public DateTimeOffset? Birthdate { get; set; }

    /// <summary>
    /// Phone numbers.
    /// </summary>
    public Phones? Phones { get; set; }

    /// <summary>
    /// When the customer was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the customer was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
