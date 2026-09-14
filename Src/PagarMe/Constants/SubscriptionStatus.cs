namespace PagarMe.Models;

/// <summary>
/// Possible values of <see cref="Subscription.Status" />.
/// </summary>
public static class SubscriptionStatus
{
    /// <summary>Active and billing.</summary>
    public const string Active = "active";

    /// <summary>Canceled.</summary>
    public const string Canceled = "canceled";

    /// <summary>Scheduled to start in the future.</summary>
    public const string Future = "future";
}
