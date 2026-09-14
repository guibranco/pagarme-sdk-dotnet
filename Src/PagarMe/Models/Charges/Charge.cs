using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// A charge: a single payment attempt inside an order or an invoice. Its <see cref="Status" /> is the payment
/// status you should check; <see cref="LastTransaction" /> holds the acquirer or bank details.
/// </summary>
public class Charge
{
    /// <summary>
    /// The charge identifier (<c>ch_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Your own reference for the charge.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// The gateway identifier.
    /// </summary>
    public string? GatewayId { get; set; }

    /// <summary>
    /// Amount in cents.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Amount actually paid in cents.
    /// </summary>
    public int? PaidAmount { get; set; }

    /// <summary>
    /// Amount canceled or refunded in cents.
    /// </summary>
    public int? CanceledAmount { get; set; }

    /// <summary>
    /// The charge status. See <see cref="ChargeStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Currency code.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// The payment method. See <see cref="PaymentMethods" />.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Due date, for boletos.
    /// </summary>
    public DateTimeOffset? DueAt { get; set; }

    /// <summary>
    /// When the charge was paid.
    /// </summary>
    public DateTimeOffset? PaidAt { get; set; }

    /// <summary>
    /// When the charge was canceled.
    /// </summary>
    public DateTimeOffset? CanceledAt { get; set; }

    /// <summary>
    /// When the charge was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the charge was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// The customer.
    /// </summary>
    public Customer? Customer { get; set; }

    /// <summary>
    /// The order the charge belongs to, when returned.
    /// </summary>
    public Order? Order { get; set; }

    /// <summary>
    /// The invoice the charge belongs to, for subscription charges.
    /// </summary>
    public Invoice? Invoice { get; set; }

    /// <summary>
    /// The most recent transaction attempted for this charge.
    /// </summary>
    public Transaction? LastTransaction { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
