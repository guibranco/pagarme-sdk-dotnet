using System;
using Newtonsoft.Json.Linq;
using PagarMe.Internal;

namespace PagarMe.Models;

/// <summary>
/// The payload Pagar.me posts to your webhook endpoint. Parse the raw request body with
/// <see cref="Parse" /> and map <see cref="Data" /> to the matching model with <see cref="GetData{T}" />.
/// </summary>
public class WebhookEvent
{
    /// <summary>
    /// The event identifier (<c>hook_...</c>).
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// The account that emitted the event.
    /// </summary>
    public WebhookAccount? Account { get; set; }

    /// <summary>
    /// The event name, for example <c>order.paid</c>. See <see cref="WebhookEventTypes" />.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// When the event was emitted.
    /// </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// The resource that triggered the event (an order, a charge, a customer...).
    /// </summary>
    public JObject? Data { get; set; }

    /// <summary>
    /// Parses the raw JSON body of a webhook request.
    /// </summary>
    /// <param name="json">The request body.</param>
    /// <returns>The parsed event.</returns>
    /// <exception cref="PagarMeException">The body is not a valid webhook payload.</exception>
    public static WebhookEvent Parse(string json)
    {
        Guard.NotNullOrWhiteSpace(json, nameof(json));

        try
        {
            return PagarMeJson.Deserialize<WebhookEvent>(json)
                ?? throw new PagarMeException("The webhook payload is empty.");
        }
        catch (Newtonsoft.Json.JsonException exception)
        {
            throw new PagarMeException(
                "The webhook payload is not valid JSON: " + exception.Message,
                exception
            );
        }
    }

    /// <summary>
    /// Maps <see cref="Data" /> to a model, for example <see cref="Order" /> for <c>order.*</c> events or
    /// <see cref="Charge" /> for <c>charge.*</c> events.
    /// </summary>
    /// <typeparam name="T">The model type.</typeparam>
    /// <returns>The mapped resource, or <see langword="null" /> when the event carries no data.</returns>
    public T? GetData<T>()
        where T : class
    {
        return Data?.ToObject<T>(PagarMeJson.CreateSerializer());
    }
}
