namespace PagarMe.Models;

/// <summary>
/// Request to update a plan. The API requires name, status, currency, interval and interval count on every
/// update, so send the full plan definition.
/// </summary>
public class UpdatePlanRequest : CreatePlanRequest
{
    /// <summary>
    /// The plan status (<c>active</c> or <c>inactive</c>). Required.
    /// </summary>
    public string? Status { get; set; }
}
