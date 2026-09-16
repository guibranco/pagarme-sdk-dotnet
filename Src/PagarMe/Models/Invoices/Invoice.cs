using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// An invoice issued for a billing cycle of a <see cref="Subscription" />.
/// </summary>
public class Invoice
{
    /// <summary>
    /// The invoice identifier (<c>in_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Your own reference for the invoice.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// The invoice URL.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Amount in cents.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// The invoice status. See <see cref="InvoiceStatus" />.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The payment method. See <see cref="PaymentMethods" />.
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Currency code.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// Number of installments.
    /// </summary>
    public int? Installments { get; set; }

    /// <summary>
    /// When the invoice is billed.
    /// </summary>
    public DateTimeOffset? BillingAt { get; set; }

    /// <summary>
    /// When the invoice was first viewed.
    /// </summary>
    public DateTimeOffset? SeenAt { get; set; }

    /// <summary>
    /// Due date.
    /// </summary>
    public DateTimeOffset? DueAt { get; set; }

    /// <summary>
    /// When the invoice was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the invoice was canceled.
    /// </summary>
    public DateTimeOffset? CanceledAt { get; set; }

    /// <summary>
    /// Total discount in cents.
    /// </summary>
    public int? TotalDiscount { get; set; }

    /// <summary>
    /// Total increment in cents.
    /// </summary>
    public int? TotalIncrement { get; set; }

    /// <summary>
    /// The customer.
    /// </summary>
    public Customer? Customer { get; set; }

    /// <summary>
    /// The subscription.
    /// </summary>
    public Subscription? Subscription { get; set; }

    /// <summary>
    /// The billing cycle.
    /// </summary>
    public SubscriptionCycle? Cycle { get; set; }

    /// <summary>
    /// The charge created for the invoice.
    /// </summary>
    public Charge? Charge { get; set; }

    /// <summary>
    /// The invoice items.
    /// </summary>
    public List<InvoiceItem>? Items { get; set; }

    /// <summary>
    /// The billing address.
    /// </summary>
    public Address? BillingAddress { get; set; }

    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
}
