using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemLanguageOp.SegmentTypeItemLanguageOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemLanguageOp : IStringEnum
{
    public static readonly SegmentTypeItemLanguageOp Is = new(Values.Is);

    public static readonly SegmentTypeItemLanguageOp Not = new(Values.Not);

    public SegmentTypeItemLanguageOp(string value)
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
    public static SegmentTypeItemLanguageOp FromCustom(string value)
    {
        return new SegmentTypeItemLanguageOp(value);
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

    public static bool operator ==(SegmentTypeItemLanguageOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemLanguageOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemLanguageOp value) => value.Value;

    public static explicit operator SegmentTypeItemLanguageOp(string value) => new(value);

    internal class SegmentTypeItemLanguageOpSerializer : JsonConverter<SegmentTypeItemLanguageOp>
    {
        public override SegmentTypeItemLanguageOp Read(
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
            return new SegmentTypeItemLanguageOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemLanguageOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemLanguageOp ReadAsPropertyName(
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
            return new SegmentTypeItemLanguageOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemLanguageOp value,
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
        public const string Is = "is";

        public const string Not = "not";
    }
}
