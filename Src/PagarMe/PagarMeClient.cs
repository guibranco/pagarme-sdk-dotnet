using System;
using System.Net.Http;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Resources;

namespace PagarMe;

/// <summary>
/// The Pagar.me API client. Create one instance per secret key and reuse it for the lifetime of your
/// application: it is thread safe and holds a single <see cref="HttpClient" />.
/// </summary>
/// <example>
/// <code>
/// using var client = new PagarMeClient("sk_test_...");
/// var order = await client.Orders.GetAsync("or_123");
/// </code>
/// </example>
public sealed class PagarMeClient : IPagarMeClient, IDisposable
{
    private readonly HttpClient? _ownedHttpClient;

    /// <summary>
    /// Initializes a client that authenticates with the given secret key and uses the default options.
    /// </summary>
    /// <param name="secretKey">The secret key (<c>sk_...</c> or <c>sk_test_...</c>).</param>
    public PagarMeClient(string secretKey)
        : this(new PagarMeClientOptions { SecretKey = secretKey }) { }

    /// <summary>
    /// Initializes a client with the given options. The SDK creates and owns the underlying
    /// <see cref="HttpClient" />; dispose the client to release it.
    /// </summary>
    /// <param name="options">The client options.</param>
    public PagarMeClient(PagarMeClientOptions options)
        : this(options, (HttpClient?)null) { }

    /// <summary>
    /// Initializes a client with the given options and an <see cref="HttpClient" /> you manage yourself,
    /// for example one produced by <c>IHttpClientFactory</c>. The SDK never disposes a client passed in.
    /// </summary>
    /// <param name="options">The client options.</param>
    /// <param name="httpClient">
    /// The HTTP client to use, or <see langword="null" /> to let the SDK create one.
    /// </param>
    public PagarMeClient(PagarMeClientOptions options, HttpClient? httpClient)
        : this(options, CreateConnection(options, httpClient, out var ownedHttpClient))
    {
        _ownedHttpClient = ownedHttpClient;
    }

    /// <summary>
    /// Initializes a client on top of an existing connection. Used by tests.
    /// </summary>
    /// <param name="options">The client options.</param>
    /// <param name="connection">The connection.</param>
    internal PagarMeClient(PagarMeClientOptions options, IApiConnection connection)
    {
        Options = Guard.NotNull(options, nameof(options));
        Guard.NotNull(connection, nameof(connection));

        Orders = new OrdersResource(connection);
        Charges = new ChargesResource(connection);
        Customers = new CustomersResource(connection);
        Tokens = new TokensResource(connection, options.PublicKey);
        Plans = new PlansResource(connection);
        Subscriptions = new SubscriptionsResource(connection);
        Invoices = new InvoicesResource(connection);
        Recipients = new RecipientsResource(connection);
        Transfers = new TransfersResource(connection);
        Payables = new PayablesResource(connection);
        Webhooks = new WebhooksResource(connection);
    }

    /// <summary>
    /// The options this client was built with.
    /// </summary>
    public PagarMeClientOptions Options { get; }

    /// <inheritdoc />
    public IOrdersResource Orders { get; }

    /// <inheritdoc />
    public IChargesResource Charges { get; }

    /// <inheritdoc />
    public ICustomersResource Customers { get; }

    /// <inheritdoc />
    public ITokensResource Tokens { get; }

    /// <inheritdoc />
    public IPlansResource Plans { get; }

    /// <inheritdoc />
    public ISubscriptionsResource Subscriptions { get; }

    /// <inheritdoc />
    public IInvoicesResource Invoices { get; }

    /// <inheritdoc />
    public IRecipientsResource Recipients { get; }

    /// <inheritdoc />
    public ITransfersResource Transfers { get; }

    /// <inheritdoc />
    public IPayablesResource Payables { get; }

    /// <inheritdoc />
    public IWebhooksResource Webhooks { get; }

    /// <summary>
    /// Releases the <see cref="HttpClient" /> created by the SDK, if any.
    /// </summary>
    public void Dispose()
    {
        _ownedHttpClient?.Dispose();
    }

    private static IApiConnection CreateConnection(
        PagarMeClientOptions options,
        HttpClient? httpClient,
        out HttpClient? ownedHttpClient
    )
    {
        Guard.NotNull(options, nameof(options));
        options.Validate();

        ownedHttpClient = null;
        if (httpClient == null)
        {
            ownedHttpClient = new HttpClient { Timeout = options.Timeout };
            httpClient = ownedHttpClient;
        }

        return new ApiConnection(httpClient, options);
    }
}
