namespace PagarMe.Models;

/// <summary>
/// Paging metadata returned together with a <see cref="PagedResponse{T}" />.
/// </summary>
public class Paging
{
    /// <summary>
    /// Total number of items across all pages, when the endpoint reports it.
    /// </summary>
    public int? Total { get; set; }

    /// <summary>
    /// URL of the previous page, or <see langword="null" /> when on the first page.
    /// </summary>
    public string? Previous { get; set; }

    /// <summary>
    /// URL of the next page, or <see langword="null" /> when on the last page.
    /// </summary>
    public string? Next { get; set; }
}
