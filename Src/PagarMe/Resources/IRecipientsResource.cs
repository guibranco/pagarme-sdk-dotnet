using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Operations on recipients (the parties that receive split payments) and their balances.
/// </summary>
public interface IRecipientsResource
{
    /// <summary>
    /// Creates a recipient. <c>POST /recipients</c>.
    /// </summary>
    /// <param name="request">The recipient to create.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created recipient.</returns>
    Task<Recipient> CreateAsync(
        CreateRecipientRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a recipient. <c>GET /recipients/{recipient_id}</c>.
    /// </summary>
    /// <param name="recipientId">The recipient identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The recipient.</returns>
    Task<Recipient> GetAsync(string recipientId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists recipients. <c>GET /recipients</c>.
    /// </summary>
    /// <param name="request">Optional paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of recipients.</returns>
    Task<PagedResponse<Recipient>> ListAsync(
        ListRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a recipient. <c>PUT /recipients/{recipient_id}</c>.
    /// </summary>
    /// <param name="recipientId">The recipient identifier.</param>
    /// <param name="request">The fields to change.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated recipient.</returns>
    Task<Recipient> UpdateAsync(
        string recipientId,
        UpdateRecipientRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves the balance of a recipient. <c>GET /recipients/{recipient_id}/balance</c>.
    /// </summary>
    /// <param name="recipientId">The recipient identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The balance.</returns>
    Task<Balance> GetBalanceAsync(string recipientId, CancellationToken cancellationToken = default);
}
