namespace PagarMe;

/// <summary>
/// Per-request options that tweak how a single API call is sent.
/// </summary>
public sealed class RequestOptions
{
    /// <summary>
    /// A unique value sent in the <c>Idempotency-Key</c> header so a retried request is not processed twice.
    /// Only meaningful for operations that create resources or move money.
    /// </summary>
    public string? IdempotencyKey { get; set; }
}
