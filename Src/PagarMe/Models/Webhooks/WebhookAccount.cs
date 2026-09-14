namespace PagarMe.Models;

/// <summary>
/// The account that emitted a webhook.
/// </summary>
public class WebhookAccount
{
    /// <summary>
    /// The account identifier (<c>acc_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The account name.
    /// </summary>
    public string? Name { get; set; }
}
