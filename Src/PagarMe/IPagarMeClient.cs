using PagarMe.Resources;

namespace PagarMe;

/// <summary>
/// Entry point of the SDK. Exposes one resource per area of the Pagar.me API. Register it in your
/// dependency injection container and inject it wherever you need to talk to Pagar.me.
/// </summary>
public interface IPagarMeClient
{
    /// <summary>
    /// Orders: create a transaction and check its payment status.
    /// </summary>
    IOrdersResource Orders { get; }

    /// <summary>
    /// Charges: inspect, capture, cancel and retry individual payments.
    /// </summary>
    IChargesResource Charges { get; }

    /// <summary>
    /// Customers, their stored cards and addresses.
    /// </summary>
    ICustomersResource Customers { get; }

    /// <summary>
    /// Card tokenization with the public key.
    /// </summary>
    ITokensResource Tokens { get; }

    /// <summary>
    /// Subscription plans.
    /// </summary>
    IPlansResource Plans { get; }

    /// <summary>
    /// Subscriptions.
    /// </summary>
    ISubscriptionsResource Subscriptions { get; }

    /// <summary>
    /// Subscription invoices.
    /// </summary>
    IInvoicesResource Invoices { get; }

    /// <summary>
    /// Recipients and their balances.
    /// </summary>
    IRecipientsResource Recipients { get; }

    /// <summary>
    /// Transfers to bank accounts.
    /// </summary>
    ITransfersResource Transfers { get; }

    /// <summary>
    /// Payables (settlement schedule).
    /// </summary>
    IPayablesResource Payables { get; }

    /// <summary>
    /// Webhook deliveries.
    /// </summary>
    IWebhooksResource Webhooks { get; }
}
