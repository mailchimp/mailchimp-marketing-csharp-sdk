using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemDateMergeOp.SegmentTypeItemDateMergeOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemDateMergeOp : IStringEnum
{
    public static readonly SegmentTypeItemDateMergeOp Is = new(Values.Is);

    public static readonly SegmentTypeItemDateMergeOp Not = new(Values.Not);

    public static readonly SegmentTypeItemDateMergeOp Less = new(Values.Less);

    public static readonly SegmentTypeItemDateMergeOp Blank = new(Values.Blank);

    public static readonly SegmentTypeItemDateMergeOp BlankNot = new(Values.BlankNot);

    public static readonly SegmentTypeItemDateMergeOp Greater = new(Values.Greater);

    public SegmentTypeItemDateMergeOp(string value)
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
    public static SegmentTypeItemDateMergeOp FromCustom(string value)
    {
        return new SegmentTypeItemDateMergeOp(value);
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

    public static bool operator ==(SegmentTypeItemDateMergeOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemDateMergeOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemDateMergeOp value) => value.Value;

    public static explicit operator SegmentTypeItemDateMergeOp(string value) => new(value);

    internal class SegmentTypeItemDateMergeOpSerializer : JsonConverter<SegmentTypeItemDateMergeOp>
    {
        public override SegmentTypeItemDateMergeOp Read(
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
            return new SegmentTypeItemDateMergeOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemDateMergeOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemDateMergeOp ReadAsPropertyName(
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
            return new SegmentTypeItemDateMergeOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemDateMergeOp value,
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

        public const string Less = "less";

        public const string Blank = "blank";

        public const string BlankNot = "blank_not";

        public const string Greater = "greater";
    }
}
