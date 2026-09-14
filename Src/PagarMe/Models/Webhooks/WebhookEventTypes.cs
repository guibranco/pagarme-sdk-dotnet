namespace PagarMe.Models;

/// <summary>
/// Event names delivered through webhooks. The API may add new events over time.
/// </summary>
public static class WebhookEventTypes
{
    /// <summary>A customer was created.</summary>
    public const string CustomerCreated = "customer.created";

    /// <summary>A customer was updated.</summary>
    public const string CustomerUpdated = "customer.updated";

    /// <summary>An address was created.</summary>
    public const string AddressCreated = "address.created";

    /// <summary>An address was updated.</summary>
    public const string AddressUpdated = "address.updated";

    /// <summary>An address was deleted.</summary>
    public const string AddressDeleted = "address.deleted";

    /// <summary>A card was created.</summary>
    public const string CardCreated = "card.created";

    /// <summary>A card was updated.</summary>
    public const string CardUpdated = "card.updated";

    /// <summary>A card was deleted.</summary>
    public const string CardDeleted = "card.deleted";

    /// <summary>A card expired.</summary>
    public const string CardExpired = "card.expired";

    /// <summary>A plan was created.</summary>
    public const string PlanCreated = "plan.created";

    /// <summary>A plan was updated.</summary>
    public const string PlanUpdated = "plan.updated";

    /// <summary>A plan was deleted.</summary>
    public const string PlanDeleted = "plan.deleted";

    /// <summary>A plan item was created.</summary>
    public const string PlanItemCreated = "plan_item.created";

    /// <summary>A plan item was updated.</summary>
    public const string PlanItemUpdated = "plan_item.updated";

    /// <summary>A plan item was deleted.</summary>
    public const string PlanItemDeleted = "plan_item.deleted";

    /// <summary>A subscription was created.</summary>
    public const string SubscriptionCreated = "subscription.created";

    /// <summary>A subscription was canceled.</summary>
    public const string SubscriptionCanceled = "subscription.canceled";

    /// <summary>A subscription item was created.</summary>
    public const string SubscriptionItemCreated = "subscription_item.created";

    /// <summary>A subscription item was updated.</summary>
    public const string SubscriptionItemUpdated = "subscription_item.updated";

    /// <summary>A subscription item was deleted.</summary>
    public const string SubscriptionItemDeleted = "subscription_item.deleted";

    /// <summary>A discount was created.</summary>
    public const string DiscountCreated = "discount.created";

    /// <summary>A discount was deleted.</summary>
    public const string DiscountDeleted = "discount.deleted";

    /// <summary>An increment was created.</summary>
    public const string IncrementCreated = "increment.created";

    /// <summary>An increment was deleted.</summary>
    public const string IncrementDeleted = "increment.deleted";

    /// <summary>An order was created.</summary>
    public const string OrderCreated = "order.created";

    /// <summary>An order was updated.</summary>
    public const string OrderUpdated = "order.updated";

    /// <summary>An order was paid.</summary>
    public const string OrderPaid = "order.paid";

    /// <summary>An order was canceled.</summary>
    public const string OrderCanceled = "order.canceled";

    /// <summary>An order was closed.</summary>
    public const string OrderClosed = "order.closed";

    /// <summary>The payment of an order failed.</summary>
    public const string OrderPaymentFailed = "order.payment_failed";

    /// <summary>An order item was created.</summary>
    public const string OrderItemCreated = "order_item.created";

    /// <summary>An order item was updated.</summary>
    public const string OrderItemUpdated = "order_item.updated";

    /// <summary>An order item was deleted.</summary>
    public const string OrderItemDeleted = "order_item.deleted";

    /// <summary>An invoice was created.</summary>
    public const string InvoiceCreated = "invoice.created";

    /// <summary>An invoice was updated.</summary>
    public const string InvoiceUpdated = "invoice.updated";

    /// <summary>An invoice was paid.</summary>
    public const string InvoicePaid = "invoice.paid";

    /// <summary>An invoice was canceled.</summary>
    public const string InvoiceCanceled = "invoice.canceled";

    /// <summary>The payment of an invoice failed.</summary>
    public const string InvoicePaymentFailed = "invoice.payment_failed";

    /// <summary>A charge was created.</summary>
    public const string ChargeCreated = "charge.created";

    /// <summary>A charge was updated.</summary>
    public const string ChargeUpdated = "charge.updated";

    /// <summary>A charge was paid.</summary>
    public const string ChargePaid = "charge.paid";

    /// <summary>The payment of a charge failed.</summary>
    public const string ChargePaymentFailed = "charge.payment_failed";

    /// <summary>A charge was refunded.</summary>
    public const string ChargeRefunded = "charge.refunded";

    /// <summary>A charge is pending.</summary>
    public const string ChargePending = "charge.pending";

    /// <summary>A charge is being processed.</summary>
    public const string ChargeProcessing = "charge.processing";

    /// <summary>A charge was underpaid.</summary>
    public const string ChargeUnderpaid = "charge.underpaid";

    /// <summary>A charge was overpaid.</summary>
    public const string ChargeOverpaid = "charge.overpaid";

    /// <summary>A charge was partially canceled.</summary>
    public const string ChargePartialCanceled = "charge.partial_canceled";

    /// <summary>A charge received a chargeback.</summary>
    public const string ChargeChargedback = "charge.chargedback";

    /// <summary>The antifraud approved a charge.</summary>
    public const string ChargeAntifraudApproved = "charge.antifraud_approved";

    /// <summary>The antifraud reproved a charge.</summary>
    public const string ChargeAntifraudReproved = "charge.antifraud_reproved";

    /// <summary>The antifraud requested a manual review of a charge.</summary>
    public const string ChargeAntifraudManual = "charge.antifraud_manual";

    /// <summary>The antifraud analysis of a charge is pending.</summary>
    public const string ChargeAntifraudPending = "charge.antifraud_pending";

    /// <summary>A chargeback was received.</summary>
    public const string ChargebackReceived = "chargeback.received";

    /// <summary>A usage record was created.</summary>
    public const string UsageCreated = "usage.created";

    /// <summary>A usage record was deleted.</summary>
    public const string UsageDeleted = "usage.deleted";

    /// <summary>A recipient was created.</summary>
    public const string RecipientCreated = "recipient.created";

    /// <summary>A recipient was updated.</summary>
    public const string RecipientUpdated = "recipient.updated";

    /// <summary>A recipient was deleted.</summary>
    public const string RecipientDeleted = "recipient.deleted";

    /// <summary>A bank account was created.</summary>
    public const string BankAccountCreated = "bank_account.created";

    /// <summary>A bank account was updated.</summary>
    public const string BankAccountUpdated = "bank_account.updated";

    /// <summary>A bank account was deleted.</summary>
    public const string BankAccountDeleted = "bank_account.deleted";

    /// <summary>A checkout was created.</summary>
    public const string CheckoutCreated = "checkout.created";

    /// <summary>A checkout was canceled.</summary>
    public const string CheckoutCanceled = "checkout.canceled";

    /// <summary>A checkout was closed.</summary>
    public const string CheckoutClosed = "checkout.closed";
}
