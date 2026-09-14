using System;
using Newtonsoft.Json.Linq;

namespace PagarMe.Models;

/// <summary>
/// A webhook delivery attempt recorded by Pagar.me.
/// </summary>
public class Webhook
{
    /// <summary>
    /// The webhook identifier (<c>hook_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The URL the payload was sent to.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// The event name. See <see cref="WebhookEventTypes" />.
    /// </summary>
    public string? Event { get; set; }

    /// <summary>
    /// The delivery status (<c>pending</c>, <c>sent</c> or <c>failed</c>).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Number of delivery attempts.
    /// </summary>
    public int? Attempts { get; set; }

    /// <summary>
    /// When the last attempt happened.
    /// </summary>
    public DateTimeOffset? LastAttempt { get; set; }

    /// <summary>
    /// The HTTP status returned by your endpoint on the last attempt.
    /// </summary>
    public string? ResponseStatus { get; set; }

    /// <summary>
    /// The raw response returned by your endpoint on the last attempt.
    /// </summary>
    public string? ResponseRaw { get; set; }

    /// <summary>
    /// The account that owns the webhook.
    /// </summary>
    public WebhookAccount? Account { get; set; }

    /// <summary>
    /// The payload that was sent. Use <see cref="WebhookEvent.GetData{T}" /> on a parsed event to map it.
    /// </summary>
    public JObject? Data { get; set; }

    /// <summary>
    /// When the webhook was created.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// When the webhook was last updated.
    /// </summary>
    public DateTimeOffset? UpdatedAt { get; set; }
}
