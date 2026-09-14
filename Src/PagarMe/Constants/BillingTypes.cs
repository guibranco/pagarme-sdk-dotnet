namespace PagarMe.Models;

/// <summary>
/// Billing types for plans and subscriptions.
/// </summary>
public static class BillingTypes
{
    /// <summary>Charged at the beginning of each cycle.</summary>
    public const string Prepaid = "prepaid";

    /// <summary>Charged at the end of each cycle.</summary>
    public const string Postpaid = "postpaid";

    /// <summary>Charged on a fixed day of the month.</summary>
    public const string ExactDay = "exact_day";
}
