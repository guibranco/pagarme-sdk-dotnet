using System.Threading;
using System.Threading.Tasks;
using PagarMe.Models;

namespace PagarMe.Resources;

/// <summary>
/// Operations on charges. A charge is a single payment attempt; check <see cref="Charge.Status" /> to know
/// whether it was paid.
/// </summary>
public interface IChargesResource
{
    /// <summary>
    /// Adds a charge to an existing open order. <c>POST /charges</c>.
    /// </summary>
    /// <param name="request">The charge to create.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The created charge.</returns>
    Task<Charge> CreateAsync(
        CreateChargeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a charge. Use it to check the payment status. <c>GET /charges/{charge_id}</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The charge.</returns>
    Task<Charge> GetAsync(string chargeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists charges. <c>GET /charges</c>.
    /// </summary>
    /// <param name="request">Optional filters and paging.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>A page of charges.</returns>
    Task<PagedResponse<Charge>> ListAsync(
        ListChargesRequest? request = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Captures a previously authorized card charge. <c>POST /charges/{charge_id}/capture</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="request">Optional capture details; omit to capture the full amount.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The captured charge.</returns>
    Task<Charge> CaptureAsync(
        string chargeId,
        CaptureChargeRequest? request = null,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancels a charge, voiding or refunding it depending on its status. <c>DELETE /charges/{charge_id}</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="request">Optional cancel details; omit to cancel the full amount.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The canceled charge.</returns>
    Task<Charge> CancelAsync(
        string chargeId,
        CancelChargeRequest? request = null,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retries a failed charge with the same payment data. <c>POST /charges/{charge_id}/retry</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The charge after the retry.</returns>
    Task<Charge> RetryAsync(
        string chargeId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Confirms that a cash charge was paid. <c>POST /charges/{charge_id}/confirm-payment</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="request">The confirmation details.</param>
    /// <param name="options">Optional per-request options, such as an idempotency key.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The confirmed charge.</returns>
    Task<Charge> ConfirmCashPaymentAsync(
        string chargeId,
        ConfirmCashPaymentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the card of a charge whose transaction was not authorized. <c>PATCH /charges/{charge_id}/card</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="request">The new card.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated charge.</returns>
    Task<Charge> UpdateCardAsync(
        string chargeId,
        UpdateChargeCardRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the due date of a boleto charge. <c>PATCH /charges/{charge_id}/due-date</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="request">The new due date.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated charge.</returns>
    Task<Charge> UpdateDueDateAsync(
        string chargeId,
        UpdateChargeDueDateRequest request,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the payment method of a pending charge. <c>PATCH /charges/{charge_id}/payment-method</c>.
    /// </summary>
    /// <param name="chargeId">The charge identifier.</param>
    /// <param name="request">The new payment method.</param>
    /// <param name="cancellationToken">A token used to cancel the operation.</param>
    /// <returns>The updated charge.</returns>
    Task<Charge> UpdatePaymentMethodAsync(
        string chargeId,
        UpdateChargePaymentMethodRequest request,
        CancellationToken cancellationToken = default
    );
}
