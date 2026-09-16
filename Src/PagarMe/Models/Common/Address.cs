using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PagarMe.Models;

/// <summary>
/// An address as returned by the API (customer address, billing address or shipping address).
/// </summary>
public class Address
{
    /// <summary>
    /// The address identifier (<c>addr_...</c>). Absent on inline billing addresses.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Number, street and neighbourhood, in that order and separated by commas.
    /// </summary>
    [JsonProperty("line_1")]
    public string? Line1 { get; set; }

    /// <summary>
    /// Complement (apartment, floor, reference point).
    /// </summary>
    [JsonProperty("line_2")]
    public string? Line2 { get; set; }

    /// <summary>
    /// Postal code, digits only.
    /// </summary>
    public string? ZipCode { get; set; }

    /// <summary>
    /// City name.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State in ISO 3166-2 format (for example <c>SP</c>).
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Country in ISO 3166-1 alpha-2 format (for example <c>BR</c>).
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// The address status (<c>active</c> or <c>deleted</c>).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// When the address was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the address was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// The customer that owns the address, when returned by the addresses endpoints.
    /// </summary>
    public Customer? Customer { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
