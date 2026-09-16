namespace PagarMe.Models;

/// <summary>
/// The result of the antifraud analysis of a <see cref="Transaction" />.
/// </summary>
public class AntifraudResponse
{
    /// <summary>
    /// The analysis status (<c>approved</c>, <c>reproved</c>, <c>pending</c>, <c>manual</c>).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The risk score.
    /// </summary>
    public string? Score { get; set; }

    /// <summary>
    /// The antifraud provider name.
    /// </summary>
    public string? ProviderName { get; set; }
}
