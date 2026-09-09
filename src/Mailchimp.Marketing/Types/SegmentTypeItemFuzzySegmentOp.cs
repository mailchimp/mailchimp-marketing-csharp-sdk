using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemFuzzySegmentOp.SegmentTypeItemFuzzySegmentOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemFuzzySegmentOp : IStringEnum
{
    public static readonly SegmentTypeItemFuzzySegmentOp FuzzyIs = new(Values.FuzzyIs);

    public static readonly SegmentTypeItemFuzzySegmentOp FuzzyNot = new(Values.FuzzyNot);

    public SegmentTypeItemFuzzySegmentOp(string value)
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
    public static SegmentTypeItemFuzzySegmentOp FromCustom(string value)
    {
        return new SegmentTypeItemFuzzySegmentOp(value);
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

    public static bool operator ==(SegmentTypeItemFuzzySegmentOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemFuzzySegmentOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemFuzzySegmentOp value) => value.Value;

    public static explicit operator SegmentTypeItemFuzzySegmentOp(string value) => new(value);

    internal class SegmentTypeItemFuzzySegmentOpSerializer
        : JsonConverter<SegmentTypeItemFuzzySegmentOp>
    {
        public override SegmentTypeItemFuzzySegmentOp Read(
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
            return new SegmentTypeItemFuzzySegmentOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemFuzzySegmentOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemFuzzySegmentOp ReadAsPropertyName(
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
            return new SegmentTypeItemFuzzySegmentOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemFuzzySegmentOp value,
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
        public const string FuzzyIs = "fuzzy_is";

        public const string FuzzyNot = "fuzzy_not";
    }
}
