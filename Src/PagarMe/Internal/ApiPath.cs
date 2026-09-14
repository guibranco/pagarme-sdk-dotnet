using System;
using System.Linq;

namespace PagarMe.Internal;

/// <summary>
/// Builds relative API paths, escaping every segment so identifiers can never break out of the path.
/// </summary>
internal static class ApiPath
{
    /// <summary>
    /// Joins the segments with slashes after escaping each one.
    /// </summary>
    /// <param name="segments">The path segments, for example <c>"customers", customerId, "cards"</c>.</param>
    /// <returns>The relative path without a leading slash.</returns>
    public static string Join(params string[] segments)
    {
        return string.Join("/", segments.Select(Uri.EscapeDataString));
    }
}
