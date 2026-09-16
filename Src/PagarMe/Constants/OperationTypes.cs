namespace PagarMe.Models;

/// <summary>
/// Credit card operation types.
/// </summary>
public static class OperationTypes
{
    /// <summary>Authorize and capture in a single step (default).</summary>
    public const string AuthAndCapture = "auth_and_capture";

    /// <summary>Authorize only; capture later with the charges endpoint.</summary>
    public const string AuthOnly = "auth_only";

    /// <summary>Pre-authorization.</summary>
    public const string PreAuth = "pre_auth";
}
