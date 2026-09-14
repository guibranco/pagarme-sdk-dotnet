using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="IInvoicesResource" />
internal sealed class InvoicesResource : IInvoicesResource
{
    private const string BasePath = "invoices";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="InvoicesResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public InvoicesResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Invoice> GetAsync(string invoiceId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(invoiceId, nameof(invoiceId));
        return _connection.GetAsync<Invoice>(
            ApiPath.Join(BasePath, invoiceId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Invoice>> ListAsync(
        ListInvoicesRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Invoice>>(BasePath, request, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Invoice> CancelAsync(string invoiceId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(invoiceId, nameof(invoiceId));
        return _connection.DeleteAsync<Invoice>(
            ApiPath.Join(BasePath, invoiceId),
            null,
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Invoice> UpdateStatusAsync(
        string invoiceId,
        UpdateInvoiceStatusRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(invoiceId, nameof(invoiceId));
        Guard.NotNull(request, nameof(request));
        return _connection.PatchAsync<Invoice>(
            ApiPath.Join(BasePath, invoiceId, "status"),
            request,
            cancellationToken
        );
    }
}
