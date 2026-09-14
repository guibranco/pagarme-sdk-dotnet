namespace PagarMe.Models;

/// <summary>
/// Automatic transfer settings of a <see cref="Recipient" />. Used both in requests and responses.
/// </summary>
public class TransferSettings
{
    /// <summary>
    /// Whether automatic transfers are enabled.
    /// </summary>
    public bool? TransferEnabled { get; set; }

    /// <summary>
    /// The transfer interval (<c>daily</c>, <c>weekly</c> or <c>monthly</c>).
    /// </summary>
    public string? TransferInterval { get; set; }

    /// <summary>
    /// The transfer day: day of the week (1-5) for weekly, day of the month (1-31) for monthly.
    /// </summary>
    public int? TransferDay { get; set; }
}
