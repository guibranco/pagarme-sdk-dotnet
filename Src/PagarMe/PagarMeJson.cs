using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe;

/// <summary>
/// JSON conventions shared by the SDK: snake_case property names, ISO-8601 UTC dates and omitted nulls.
/// Use <see cref="Settings" /> when you need to (de)serialize SDK models yourself, for example when binding
/// webhook payloads in an ASP.NET Core controller.
/// </summary>
public static class PagarMeJson
{
    /// <summary>
    /// The serializer settings used for every request and response.
    /// </summary>
    public static JsonSerializerSettings Settings { get; } = CreateSettings();

    /// <summary>
    /// Serializes a value using the SDK conventions.
    /// </summary>
    /// <param name="value">The value to serialize.</param>
    /// <returns>The JSON document.</returns>
    public static string Serialize(object? value) => JsonConvert.SerializeObject(value, Settings);

    /// <summary>
    /// Deserializes a JSON document using the SDK conventions.
    /// </summary>
    /// <typeparam name="T">The target type.</typeparam>
    /// <param name="json">The JSON document.</param>
    /// <returns>The deserialized value, or <see langword="null" /> when the document is <c>null</c>.</returns>
    public static T? Deserialize<T>(string json) =>
        JsonConvert.DeserializeObject<T>(json, Settings);

    /// <summary>
    /// Creates a <see cref="JsonSerializer" /> configured with the SDK conventions.
    /// </summary>
    /// <returns>A new serializer instance.</returns>
    public static JsonSerializer CreateSerializer() => JsonSerializer.Create(Settings);

    private static JsonSerializerSettings CreateSettings()
    {
        return new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy(),
            },
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            DateParseHandling = DateParseHandling.DateTimeOffset,
            MissingMemberHandling = MissingMemberHandling.Ignore,
        };
    }
}
