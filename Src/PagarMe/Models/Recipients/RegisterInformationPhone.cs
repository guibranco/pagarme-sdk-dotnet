namespace PagarMe.Models;

/// <summary>
/// A phone number in the registration data of a recipient.
/// </summary>
public class RegisterInformationPhone
{
    /// <summary>
    /// The area code (DDD).
    /// </summary>
    public string? Ddd { get; set; }

    /// <summary>
    /// The subscriber number.
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// The phone type (<c>mobile</c> or <c>landline</c>).
    /// </summary>
    public string? Type { get; set; }
}
