namespace PagarMe.Models;

/// <summary>
/// A split rule as returned on a <see cref="Transaction" />.
/// </summary>
public class Split
{
    /// <summary>
    /// The rule type (<c>flat</c> or <c>percentage</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The amount: cents when <see cref="Type" /> is <c>flat</c>, otherwise a percentage.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// The gateway identifier of the rule.
    /// </summary>
    public string? GatewayId { get; set; }

    /// <summary>
    /// The recipient receiving the amount.
    /// </summary>
    public Recipient? Recipient { get; set; }

    /// <summary>
    /// Fee and liability options.
    /// </summary>
    public SplitOptions? Options { get; set; }
}
