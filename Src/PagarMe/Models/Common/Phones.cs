namespace PagarMe.Models;

/// <summary>
/// The phone numbers of a customer.
/// </summary>
public class Phones
{
    /// <summary>
    /// Landline number.
    /// </summary>
    public Phone? HomePhone { get; set; }

    /// <summary>
    /// Mobile number.
    /// </summary>
    public Phone? MobilePhone { get; set; }
}
