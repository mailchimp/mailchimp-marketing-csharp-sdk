using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListAdviceReportsResponseAdviceItemType.ListAdviceReportsResponseAdviceItemTypeSerializer)
)]
[Serializable]
public readonly record struct ListAdviceReportsResponseAdviceItemType : IStringEnum
{
    public static readonly ListAdviceReportsResponseAdviceItemType Negative = new(Values.Negative);

    public static readonly ListAdviceReportsResponseAdviceItemType Positive = new(Values.Positive);

    public static readonly ListAdviceReportsResponseAdviceItemType Neutral = new(Values.Neutral);

    public ListAdviceReportsResponseAdviceItemType(string value)
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
    public static ListAdviceReportsResponseAdviceItemType FromCustom(string value)
    {
        return new ListAdviceReportsResponseAdviceItemType(value);
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

    public static bool operator ==(ListAdviceReportsResponseAdviceItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListAdviceReportsResponseAdviceItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListAdviceReportsResponseAdviceItemType value) =>
        value.Value;

    public static explicit operator ListAdviceReportsResponseAdviceItemType(string value) =>
        new(value);

    internal class ListAdviceReportsResponseAdviceItemTypeSerializer
        : JsonConverter<ListAdviceReportsResponseAdviceItemType>
    {
        public override ListAdviceReportsResponseAdviceItemType Read(
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
            return new ListAdviceReportsResponseAdviceItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAdviceReportsResponseAdviceItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAdviceReportsResponseAdviceItemType ReadAsPropertyName(
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
            return new ListAdviceReportsResponseAdviceItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAdviceReportsResponseAdviceItemType value,
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
        public const string Negative = "negative";

        public const string Positive = "positive";

        public const string Neutral = "neutral";
    }
}
