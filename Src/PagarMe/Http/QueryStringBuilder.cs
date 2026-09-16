using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Http;

/// <summary>
/// Turns a plain object into a query string. Property names follow the same snake_case convention used for
/// JSON bodies (or the explicit <see cref="JsonPropertyAttribute" /> name), nulls are skipped, dates are sent as
/// ISO-8601 UTC and collections are repeated once per item.
/// </summary>
internal static class QueryStringBuilder
{
    private const string DateFormat = "yyyy-MM-dd'T'HH:mm:ss'Z'";

    private static readonly SnakeCaseNamingStrategy Naming = new();

    /// <summary>
    /// Builds a query string (without the leading <c>?</c>) from the public properties of <paramref name="parameters" />.
    /// </summary>
    /// <param name="parameters">The object holding the parameters, or <see langword="null" />.</param>
    /// <returns>The encoded query string, or an empty string when there is nothing to send.</returns>
    public static string Build(object? parameters)
    {
        if (parameters == null)
        {
            return string.Empty;
        }

        var builder = new StringBuilder();
        var properties = parameters
            .GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var property in properties)
        {
            if (!property.CanRead || property.GetIndexParameters().Length > 0)
            {
                continue;
            }

            var value = property.GetValue(parameters);
            if (value == null)
            {
                continue;
            }

            var name = ResolveName(property);

            if (value is string text)
            {
                Append(builder, name, text);
            }
            else if (value is IEnumerable items)
            {
                foreach (var item in items)
                {
                    if (item != null)
                    {
                        Append(builder, name, Format(item));
                    }
                }
            }
            else
            {
                Append(builder, name, Format(value));
            }
        }

        return builder.ToString();
    }

    private static string ResolveName(PropertyInfo property)
    {
        var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
        return !string.IsNullOrEmpty(attribute?.PropertyName)
            ? attribute!.PropertyName!
            : Naming.GetPropertyName(property.Name, false);
    }

    private static string Format(object value)
    {
        switch (value)
        {
            case bool flag:
                return flag ? "true" : "false";
            case DateTimeOffset dateTimeOffset:
                return dateTimeOffset
                    .ToUniversalTime()
                    .ToString(DateFormat, CultureInfo.InvariantCulture);
            case DateTime dateTime:
                var utc =
                    dateTime.Kind == DateTimeKind.Local ? dateTime.ToUniversalTime() : dateTime;
                return utc.ToString(DateFormat, CultureInfo.InvariantCulture);
            case IFormattable formattable:
                return formattable.ToString(null, CultureInfo.InvariantCulture);
            default:
                return value.ToString() ?? string.Empty;
        }
    }

    private static void Append(StringBuilder builder, string name, string value)
    {
        if (builder.Length > 0)
        {
            builder.Append('&');
        }

        builder.Append(Uri.EscapeDataString(name)).Append('=').Append(Uri.EscapeDataString(value));
    }
}
