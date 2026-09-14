using System;
using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Pix payment details. Provide either <see cref="ExpiresIn" /> or <see cref="ExpiresAt" />.
/// </summary>
public class PixPaymentRequest
{
    /// <summary>
    /// Number of seconds the QR code stays valid.
    /// </summary>
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// The moment the QR code expires.
    /// </summary>
    public DateTimeOffset? ExpiresAt { get; set; }

    /// <summary>
    /// Extra information displayed to the payer.
    /// </summary>
    public List<PixAdditionalInformation>? AdditionalInformation { get; set; }
}
