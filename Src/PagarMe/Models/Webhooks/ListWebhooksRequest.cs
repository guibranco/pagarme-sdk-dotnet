using System;

namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing webhooks.
/// </summary>
public class ListWebhooksRequest : ListRequest
{
    /// <summary>
    /// Filter by delivery status.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Filter by event name. See <see cref="WebhookEventTypes" />.
    /// </summary>
    public string? Event { get; set; }

    /// <summary>
    /// Only webhooks created at or after this moment.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; set; }

    /// <summary>
    /// Only webhooks created at or before this moment.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; set; }
}
