namespace PagarMe.Models;

/// <summary>
/// Filters accepted when listing customers.
/// </summary>
public class ListCustomersRequest : ListRequest
{
    /// <summary>
    /// Filter by name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Filter by document number.
    /// </summary>
    public string? Document { get; set; }

    /// <summary>
    /// Filter by e-mail address.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Filter by gender.
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// Filter by your own reference.
    /// </summary>
    public string? Code { get; set; }
}
