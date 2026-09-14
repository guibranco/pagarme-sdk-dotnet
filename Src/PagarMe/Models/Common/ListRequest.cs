namespace PagarMe.Models;

/// <summary>
/// Paging filters accepted by every list endpoint. Both values are optional; the API defaults to the first
/// page of 10 items. Resource specific filters derive from this class.
/// </summary>
public class ListRequest
{
    /// <summary>
    /// The page number (1-based).
    /// </summary>
    public int? Page { get; set; }

    /// <summary>
    /// The number of items per page.
    /// </summary>
    public int? Size { get; set; }
}
