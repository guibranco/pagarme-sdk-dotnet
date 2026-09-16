using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to capture a previously authorized card charge. Omit <see cref="Amount" /> to capture the full amount.
/// </summary>
public class CaptureChargeRequest
{
    /// <summary>
    /// Amount to capture in cents. Defaults to the authorized amount.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Your own reference for the capture.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Split rules applied to the captured amount.
    /// </summary>
    public List<SplitRequest>? Split { get; set; }
}
