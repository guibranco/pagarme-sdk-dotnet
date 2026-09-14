namespace PagarMe.Models;

/// <summary>
/// A split rule sending part of a payment to a recipient.
/// </summary>
public class SplitRequest
{
    /// <summary>
    /// The amount: cents when <see cref="Type" /> is <c>flat</c>, otherwise a percentage. Required.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// The recipient identifier (<c>rp_...</c>). Required.
    /// </summary>
    public string? RecipientId { get; set; }

    /// <summary>
    /// The rule type (<c>flat</c> or <c>percentage</c>). Required.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Fee and liability options.
    /// </summary>
    public SplitOptions? Options { get; set; }
}
