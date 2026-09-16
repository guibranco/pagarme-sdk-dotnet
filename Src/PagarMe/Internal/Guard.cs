using System;

namespace PagarMe.Internal;

/// <summary>
/// Argument validation helpers.
/// </summary>
internal static class Guard
{
    /// <summary>
    /// Ensures a reference argument is not <see langword="null" />.
    /// </summary>
    public static T NotNull<T>(T? value, string paramName)
        where T : class
    {
        return value ?? throw new ArgumentNullException(paramName);
    }

    /// <summary>
    /// Ensures a string argument (typically a resource identifier) has content.
    /// </summary>
    public static string NotNullOrWhiteSpace(string? value, string paramName)
    {
        if (value == null)
        {
            throw new ArgumentNullException(paramName);
        }

        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("The value cannot be empty.", paramName);
        }

        return value;
    }
}
