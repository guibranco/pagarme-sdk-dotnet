using System.Collections.Generic;

namespace PagarMe.Models;

/// <summary>
/// The envelope returned by every list endpoint: a page of items plus paging information.
/// </summary>
/// <typeparam name="T">The type of the listed items.</typeparam>
public class PagedResponse<T>
{
    /// <summary>
    /// The items in the current page.
    /// </summary>
    public List<T> Data { get; set; } = new();

    /// <summary>
    /// Paging information for the current result set.
    /// </summary>
    public Paging Paging { get; set; } = new();
}
