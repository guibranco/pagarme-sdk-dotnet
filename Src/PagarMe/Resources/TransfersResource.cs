using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="ITransfersResource" />
internal sealed class TransfersResource : ITransfersResource
{
    private const string BasePath = "transfers";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="TransfersResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public TransfersResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Transfer> CreateAsync(
        CreateTransferRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Transfer>(BasePath, request, options, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Transfer> GetAsync(string transferId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(transferId, nameof(transferId));
        return _connection.GetAsync<Transfer>(
            ApiPath.Join(BasePath, transferId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public async Task<List<Transfer>> ListAsync(
        ListTransfersRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        var transfers = await _connection
            .GetAsync<List<Transfer>>(BasePath, request, cancellationToken)
            .ConfigureAwait(false);

        return transfers ?? new List<Transfer>();
    }
}
