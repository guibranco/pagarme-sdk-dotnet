using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="ITokensResource" />
internal sealed class TokensResource : ITokensResource
{
    private const string BasePath = "tokens";

    private readonly IApiConnection _connection;
    private readonly string? _publicKey;

    /// <summary>
    /// Initializes a new instance of the <see cref="TokensResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    /// <param name="publicKey">The default public key, or <see langword="null" /> when none is configured.</param>
    public TokensResource(IApiConnection connection, string? publicKey)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
        _publicKey = publicKey;
    }

    /// <inheritdoc />
    public Task<Token> CreateAsync(
        CreateTokenRequest request,
        CancellationToken cancellationToken = default
    )
    {
        if (string.IsNullOrWhiteSpace(_publicKey))
        {
            throw new PagarMeException(
                "A public key is required to create card tokens. Set PagarMeClientOptions.PublicKey or pass the key explicitly."
            );
        }

        return CreateAsync(request, _publicKey!, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Token> CreateAsync(
        CreateTokenRequest request,
        string publicKey,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        Guard.NotNullOrWhiteSpace(publicKey, nameof(publicKey));

        var apiRequest = new ApiRequest(HttpMethod.Post, BasePath)
        {
            Body = request,
            Query = new TokenQuery { AppId = publicKey },
            Authenticate = false,
        };

        return _connection.SendAsync<Token>(apiRequest, cancellationToken);
    }

    /// <summary>
    /// Query string of the tokens endpoint. The parameter name is camelCase, unlike the rest of the API.
    /// </summary>
    private sealed class TokenQuery
    {
        [JsonProperty("appId")]
        public string? AppId { get; set; }
    }
}
