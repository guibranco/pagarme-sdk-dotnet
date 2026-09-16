using System.Collections.Generic;
using Newtonsoft.Json;

namespace PagarMe.Models;

/// <summary>
/// An address sent to the API: when creating or updating a customer address, as the billing address of a
/// card or as the shipping address of an order.
/// </summary>
public class AddressRequest
{
    /// <summary>
    /// Number, street and neighbourhood, in that order and separated by commas. Max 256 characters. Required.
    /// </summary>
    [JsonProperty("line_1")]
    public string? Line1 { get; set; }

    /// <summary>
    /// Complement (apartment, floor, reference point). Max 128 characters.
    /// </summary>
    [JsonProperty("line_2")]
    public string? Line2 { get; set; }

    /// <summary>
    /// Postal code, digits only. Required.
    /// </summary>
    public string? ZipCode { get; set; }

    /// <summary>
    /// City name. Required.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State in ISO 3166-2 format (for example <c>SP</c>). Required.
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Country in ISO 3166-1 alpha-2 format (for example <c>BR</c>). Required.
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
