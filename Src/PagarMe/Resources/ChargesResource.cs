using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="IChargesResource" />
internal sealed class ChargesResource : IChargesResource
{
    private const string BasePath = "charges";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="ChargesResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public ChargesResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Charge> CreateAsync(
        CreateChargeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Charge>(BasePath, request, options, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Charge> GetAsync(string chargeId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        return _connection.GetAsync<Charge>(
            ApiPath.Join(BasePath, chargeId),
            null,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<PagedResponse<Charge>> ListAsync(
        ListChargesRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Charge>>(BasePath, request, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Charge> CaptureAsync(
        string chargeId,
        CaptureChargeRequest? request = null,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        return _connection.PostAsync<Charge>(
            ApiPath.Join(BasePath, chargeId, "capture"),
            request ?? new CaptureChargeRequest(),
            options,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Charge> CancelAsync(
        string chargeId,
        CancelChargeRequest? request = null,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        return _connection.DeleteAsync<Charge>(
            ApiPath.Join(BasePath, chargeId),
            request,
            options,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Charge> RetryAsync(
        string chargeId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        return _connection.PostAsync<Charge>(
            ApiPath.Join(BasePath, chargeId, "retry"),
            null,
            options,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Charge> ConfirmCashPaymentAsync(
        string chargeId,
        ConfirmCashPaymentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Charge>(
            ApiPath.Join(BasePath, chargeId, "confirm-payment"),
            request,
            options,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Charge> UpdateCardAsync(
        string chargeId,
        UpdateChargeCardRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        Guard.NotNull(request, nameof(request));
        return _connection.PatchAsync<Charge>(
            ApiPath.Join(BasePath, chargeId, "card"),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Charge> UpdateDueDateAsync(
        string chargeId,
        UpdateChargeDueDateRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        Guard.NotNull(request, nameof(request));
        return _connection.PatchAsync<Charge>(
            ApiPath.Join(BasePath, chargeId, "due-date"),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Charge> UpdatePaymentMethodAsync(
        string chargeId,
        UpdateChargePaymentMethodRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(chargeId, nameof(chargeId));
        Guard.NotNull(request, nameof(request));
        return _connection.PatchAsync<Charge>(
            ApiPath.Join(BasePath, chargeId, "payment-method"),
            request,
            cancellationToken
        );
    }
}
