using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="IRecipientsResource" />
internal sealed class RecipientsResource : IRecipientsResource
{
    private const string BasePath = "recipients";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="RecipientsResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public RecipientsResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Recipient> CreateAsync(
        CreateRecipientRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Recipient>(BasePath, request, null, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Recipient> GetAsync(
        string recipientId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(recipientId, nameof(recipientId));
        return _connection.GetAsync<Recipient>(
            ApiPath.Join(BasePath, recipientId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Recipient>> ListAsync(
        ListRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Recipient>>(BasePath, request, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Recipient> UpdateAsync(
        string recipientId,
        UpdateRecipientRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(recipientId, nameof(recipientId));
        Guard.NotNull(request, nameof(request));
        return _connection.PutAsync<Recipient>(
            ApiPath.Join(BasePath, recipientId),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Balance> GetBalanceAsync(
        string recipientId,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(recipientId, nameof(recipientId));
        return _connection.GetAsync<Balance>(
            ApiPath.Join(BasePath, recipientId, "balance"),
            null,
            cancellationToken
        );
    }
}
