using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// Request to cancel (void or refund) a charge. Omit <see cref="Amount" /> to cancel the full amount.
/// </summary>
public class CancelChargeRequest
{
    /// <summary>
    /// Amount to cancel in cents. Defaults to the full amount.
    /// </summary>
    public int? Amount { get; set; }

    /// <summary>
    /// Bank account to refund to, required when refunding paid boletos or Pix charges to a different account.
    /// </summary>
    public BankAccountRequest? BankAccount { get; set; }

    /// <summary>
    /// Split rules applied to the refunded amount.
    /// </summary>
    public List<SplitRequest>? Split { get; set; }
}
