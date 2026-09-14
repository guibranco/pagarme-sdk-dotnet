namespace PagarMe.Models;

/// <summary>
/// Options of a split rule.
/// </summary>
public class SplitOptions
{
    /// <summary>
    /// Whether the recipient pays its share of the processing fee.
    /// </summary>
    public bool? ChargeProcessingFee { get; set; }

    /// <summary>
    /// Whether the recipient receives the remainder of the fee rounding.
    /// </summary>
    public bool? ChargeRemainderFee { get; set; }

    /// <summary>
    /// Whether the recipient is liable for chargebacks.
    /// </summary>
    public bool? Liable { get; set; }
}
