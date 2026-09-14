namespace PagarMe.Models;

/// <summary>
/// An interest or fine rule applied to an overdue boleto.
/// </summary>
public class BoletoFeeRequest
{
    /// <summary>
    /// Number of days after the due date before the rule applies.
    /// </summary>
    public int? Days { get; set; }

    /// <summary>
    /// The rule type (<c>percentage</c> or <c>flat</c>).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// The amount: cents when <see cref="Type" /> is <c>flat</c>, otherwise a percentage.
    /// </summary>
    public string? Amount { get; set; }
}
