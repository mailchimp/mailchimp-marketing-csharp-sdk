using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListOptionsMatch.ListOptionsMatchSerializer))]
[Serializable]
public readonly record struct ListOptionsMatch : IStringEnum
{
    public static readonly ListOptionsMatch Any = new(Values.Any);

    public static readonly ListOptionsMatch All = new(Values.All);

    public ListOptionsMatch(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ListOptionsMatch FromCustom(string value)
    {
        return new ListOptionsMatch(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ListOptionsMatch value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListOptionsMatch value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListOptionsMatch value) => value.Value;

    public static explicit operator ListOptionsMatch(string value) => new(value);

    internal class ListOptionsMatchSerializer : JsonConverter<ListOptionsMatch>
    {
        public override ListOptionsMatch Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new ListOptionsMatch(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListOptionsMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListOptionsMatch ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new ListOptionsMatch(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListOptionsMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Any = "any";

        public const string All = "all";
    }
}
