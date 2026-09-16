using System;

namespace PagarMe;

/// <summary>
/// Configuration used to build a <see cref="PagarMeClient" />.
/// </summary>
public sealed class PagarMeClientOptions
{
    /// <summary>
    /// The default base address of the Pagar.me core API (v5).
    /// </summary>
    public const string DefaultBaseUrl = "https://api.pagar.me/core/v5/";

    /// <summary>
    /// The default request timeout (30 seconds).
    /// </summary>
    public static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(30);

    /// <summary>
    /// The secret key (<c>sk_...</c> or <c>sk_test_...</c>) used to authenticate every request via HTTP Basic auth.
    /// Required.
    /// </summary>
    public string SecretKey { get; set; } = string.Empty;

    /// <summary>
    /// The public key (<c>pk_...</c> or <c>pk_test_...</c>). Only required when creating card tokens through
    /// <see cref="IPagarMeClient.Tokens" />.
    /// </summary>
    public string? PublicKey { get; set; }

    /// <summary>
    /// The base URL of the API. Defaults to <see cref="DefaultBaseUrl" />. Override it to point to a mock server.
    /// </summary>
    public string BaseUrl { get; set; } = DefaultBaseUrl;

    /// <summary>
    /// The timeout applied to the <see cref="System.Net.Http.HttpClient" /> created by the SDK.
    /// Ignored when you supply your own <see cref="System.Net.Http.HttpClient" />.
    /// </summary>
    public TimeSpan Timeout { get; set; } = DefaultTimeout;

    /// <summary>
    /// Validates the options and throws when they are not usable.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when a required value is missing or invalid.</exception>
    internal void Validate()
    {
        if (string.IsNullOrWhiteSpace(SecretKey))
        {
            throw new ArgumentException("The Pagar.me secret key is required.", nameof(SecretKey));
        }

        if (
            string.IsNullOrWhiteSpace(BaseUrl)
            || !Uri.TryCreate(BaseUrl, UriKind.Absolute, out var uri)
            || (uri.Scheme != Uri.UriSchemeHttps && uri.Scheme != Uri.UriSchemeHttp)
        )
        {
            throw new ArgumentException(
                "The base URL must be an absolute HTTP or HTTPS URL.",
                nameof(BaseUrl)
            );
        }

        if (Timeout <= TimeSpan.Zero)
        {
            throw new ArgumentException("The timeout must be greater than zero.", nameof(Timeout));
        }
    }

    /// <summary>
    /// Returns the base address as an absolute <see cref="Uri" /> that always ends with a slash so relative
    /// resource paths combine correctly.
    /// </summary>
    internal Uri GetBaseUri()
    {
        var url = BaseUrl.EndsWith("/", StringComparison.Ordinal) ? BaseUrl : BaseUrl + "/";
        return new Uri(url, UriKind.Absolute);
    }
}
