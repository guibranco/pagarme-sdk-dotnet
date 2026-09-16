using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to add a charge to an existing open order.
/// </summary>
public class CreateChargeRequest
{
    /// <summary>
    /// The identifier of the open order the charge belongs to. Required.
    /// </summary>
    public string? OrderId { get; set; }

    /// <summary>
    /// Amount in cents. Required.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// The payment details. Required.
    /// </summary>
    public PaymentRequest? Payment { get; set; }

    /// <summary>
    /// The identifier of an existing customer.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Inline customer data.
    /// </summary>
    public CustomerRequest? Customer { get; set; }

    /// <summary>
    /// Due date, for boletos.
    /// </summary>
    public DateTimeOffset? DueAt { get; set; }

    /// <summary>
    /// Your own reference for the charge.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
