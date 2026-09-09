using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSegmentsListsRequestExcludeType.ListSegmentsListsRequestExcludeTypeSerializer)
)]
[Serializable]
public readonly record struct ListSegmentsListsRequestExcludeType : IStringEnum
{
    public static readonly ListSegmentsListsRequestExcludeType Saved = new(Values.Saved);

    public static readonly ListSegmentsListsRequestExcludeType Static = new(Values.Static);

    public static readonly ListSegmentsListsRequestExcludeType Fuzzy = new(Values.Fuzzy);

    public ListSegmentsListsRequestExcludeType(string value)
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
    public static ListSegmentsListsRequestExcludeType FromCustom(string value)
    {
        return new ListSegmentsListsRequestExcludeType(value);
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

    public static bool operator ==(ListSegmentsListsRequestExcludeType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListSegmentsListsRequestExcludeType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListSegmentsListsRequestExcludeType value) =>
        value.Value;

    public static explicit operator ListSegmentsListsRequestExcludeType(string value) => new(value);

    internal class ListSegmentsListsRequestExcludeTypeSerializer
        : JsonConverter<ListSegmentsListsRequestExcludeType>
    {
        public override ListSegmentsListsRequestExcludeType Read(
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
            return new ListSegmentsListsRequestExcludeType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSegmentsListsRequestExcludeType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSegmentsListsRequestExcludeType ReadAsPropertyName(
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
            return new ListSegmentsListsRequestExcludeType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSegmentsListsRequestExcludeType value,
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
