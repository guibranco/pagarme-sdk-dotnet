using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="IPayablesResource" />
internal sealed class PayablesResource : IPayablesResource
{
    private const string BasePath = "payables";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="PayablesResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public PayablesResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Payable> GetAsync(string payableId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(payableId, nameof(payableId));
        return _connection.GetAsync<Payable>(
            ApiPath.Join(BasePath, payableId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Payable>> ListAsync(
        ListPayablesRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Payable>>(BasePath, request, cancellationToken);
    }
}
