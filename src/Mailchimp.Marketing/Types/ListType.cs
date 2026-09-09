using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListType.ListTypeSerializer))]
[Serializable]
public readonly record struct ListType : IStringEnum
{
    public static readonly ListType Saved = new(Values.Saved);

    public static readonly ListType Static = new(Values.Static);

    public static readonly ListType Fuzzy = new(Values.Fuzzy);

    public ListType(string value)
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
    public static ListType FromCustom(string value)
    {
        return new ListType(value);
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

    public static bool operator ==(ListType value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(ListType value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(ListType value) => value.Value;

    public static explicit operator ListType(string value) => new(value);

    internal class ListTypeSerializer : JsonConverter<ListType>
    {
        public override ListType Read(
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
            return new ListType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListType ReadAsPropertyName(
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
            return new ListType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListType value,
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
        public const string Saved = "saved";

        public const string Static = "static";

        public const string Fuzzy = "fuzzy";
    }
}
