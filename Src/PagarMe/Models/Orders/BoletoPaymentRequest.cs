using System;

namespace PagarMe.Models;

/// <summary>
/// Boleto payment details.
/// </summary>
public class BoletoPaymentRequest
{
    /// <summary>
    /// Instructions printed on the boleto.
    /// </summary>
    public string? Instructions { get; set; }

    /// <summary>
    /// Due date.
    /// </summary>
    public DateTimeOffset? DueAt { get; set; }

    /// <summary>
    /// Your own document number printed on the boleto.
    /// </summary>
    public string? DocumentNumber { get; set; }

    /// <summary>
    /// The boleto type. See <see cref="BoletoTypes" />.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Interest applied after the due date.
    /// </summary>
    public BoletoFeeRequest? Interest { get; set; }

    /// <summary>
    /// Fine applied after the due date.
    /// </summary>
    public BoletoFeeRequest? Fine { get; set; }
}
