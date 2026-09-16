using System.Threading;
using System.Threading.Tasks;
using PagarMe.Http;
using PagarMe.Internal;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <inheritdoc cref="IPlansResource" />
internal sealed class PlansResource : IPlansResource
{
    private const string BasePath = "plans";

    private readonly IApiConnection _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="PlansResource" /> class.
    /// </summary>
    /// <param name="connection">The API connection.</param>
    public PlansResource(IApiConnection connection)
    {
        _connection = Guard.NotNull(connection, nameof(connection));
    }

    /// <inheritdoc />
    public Task<Plan> CreateAsync(
        CreatePlanRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNull(request, nameof(request));
        return _connection.PostAsync<Plan>(BasePath, request, null, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Plan> GetAsync(string planId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(planId, nameof(planId));
        return _connection.GetAsync<Plan>(ApiPath.Join(BasePath, planId), null, cancellationToken);
    }

    /// <inheritdoc />
    public Task<PagedResponse<Plan>> ListAsync(
        ListPlansRequest? request = null,
        CancellationToken cancellationToken = default
    )
    {
        return _connection.GetAsync<PagedResponse<Plan>>(BasePath, request, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Plan> UpdateAsync(
        string planId,
        UpdatePlanRequest request,
        CancellationToken cancellationToken = default
    )
    {
        Guard.NotNullOrWhiteSpace(planId, nameof(planId));
        Guard.NotNull(request, nameof(request));
        return _connection.PutAsync<Plan>(
            ApiPath.Join(BasePath, planId),
            request,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<Plan> DeleteAsync(string planId, CancellationToken cancellationToken = default)
    {
        Guard.NotNullOrWhiteSpace(planId, nameof(planId));
        return _connection.DeleteAsync<Plan>(
            ApiPath.Join(BasePath, planId),
            null,
            null,
            cancellationToken
        );
    }
}
