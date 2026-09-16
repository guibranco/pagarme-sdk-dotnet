using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Operations on plans.
/// </summary>
public interface IPlansResource
{
    /// <summary>
    /// Creates a plan. <c>POST /plans</c>.
    /// </summary>
    /// <param name="request">The plan to create.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created plan.</returns>
    Task<Plan> CreateAsync(
        CreatePlanRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a plan. <c>GET /plans/{plan_id}</c>.
    /// </summary>
    /// <param name="planId">The plan identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The plan.</returns>
    Task<Plan> GetAsync(string planId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists plans. <c>GET /plans</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of plans.</returns>
    Task<PagedResponse<Plan>> ListAsync(
        ListPlansRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a plan. <c>PUT /plans/{plan_id}</c>.
    /// </summary>
    /// <param name="planId">The plan identifier.</param>
    /// <param name="request">The full plan definition.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated plan.</returns>
    Task<Plan> UpdateAsync(
        string planId,
        UpdatePlanRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a plan. Existing subscriptions keep billing. <c>DELETE /plans/{plan_id}</c>.
    /// </summary>
    /// <param name="planId">The plan identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The deleted plan.</returns>
    Task<Plan> DeleteAsync(string planId, CancellationToken cancellationToken = default);
}
