using System;

namespace PagarMe.Models;

/// <summary>
/// Request to change the due date of a boleto charge.
/// </summary>
public class UpdateChargeDueDateRequest
{
    /// <summary>
    /// The new due date. Required.
    /// </summary>
    public DateTimeOffset? DueAt { get; set; }
}
