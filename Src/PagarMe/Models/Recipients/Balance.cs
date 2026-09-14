namespace PagarMe.Models;

/// <summary>
/// The balance of a <see cref="Recipient" />.
/// </summary>
public class Balance
{
    /// <summary>
    /// Currency code.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// Amount available for transfer, in cents.
    /// </summary>
    public long? AvailableAmount { get; set; }

    /// <summary>
    /// Amount still waiting for settlement, in cents.
    /// </summary>
    public long? WaitingFundsAmount { get; set; }

    /// <summary>
    /// Amount already transferred, in cents.
    /// </summary>
    public long? TransferredAmount { get; set; }

    /// <summary>
    /// The recipient the balance belongs to.
    /// </summary>
    public Recipient? Recipient { get; set; }
}
