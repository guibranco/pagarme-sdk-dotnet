using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Automatic anticipation settings of a <see cref="Recipient" />. Used both in requests and responses.
/// </summary>
public class AutomaticAnticipationSettings
{
    /// <summary>
    /// Whether automatic anticipation is enabled.
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// The anticipation type (<c>full</c> or <c>1025</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The percentage of the volume anticipated.
    /// </summary>
    public int? VolumePercentage { get; set; }

    /// <summary>
    /// The days of the month anticipations happen, for <c>1025</c> type.
    /// </summary>
    public List<int>? Days { get; set; }

    /// <summary>
    /// Delay in days.
    /// </summary>
    public int? Delay { get; set; }
}
