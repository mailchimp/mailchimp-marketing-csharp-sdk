using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemTextMergeOp.SegmentTypeItemTextMergeOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemTextMergeOp : IStringEnum
{
    public static readonly SegmentTypeItemTextMergeOp Is = new(Values.Is);

    public static readonly SegmentTypeItemTextMergeOp Not = new(Values.Not);

    public static readonly SegmentTypeItemTextMergeOp Contains = new(Values.Contains);

    public static readonly SegmentTypeItemTextMergeOp Notcontain = new(Values.Notcontain);

    public static readonly SegmentTypeItemTextMergeOp Starts = new(Values.Starts);

    public static readonly SegmentTypeItemTextMergeOp Ends = new(Values.Ends);

    public static readonly SegmentTypeItemTextMergeOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemTextMergeOp Less = new(Values.Less);

    public static readonly SegmentTypeItemTextMergeOp Blank = new(Values.Blank);

    public static readonly SegmentTypeItemTextMergeOp BlankNot = new(Values.BlankNot);

    public SegmentTypeItemTextMergeOp(string value)
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
    public static SegmentTypeItemTextMergeOp FromCustom(string value)
    {
        return new SegmentTypeItemTextMergeOp(value);
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

    public static bool operator ==(SegmentTypeItemTextMergeOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemTextMergeOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemTextMergeOp value) => value.Value;

    public static explicit operator SegmentTypeItemTextMergeOp(string value) => new(value);

    internal class SegmentTypeItemTextMergeOpSerializer : JsonConverter<SegmentTypeItemTextMergeOp>
    {
        public override SegmentTypeItemTextMergeOp Read(
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
            return new SegmentTypeItemTextMergeOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemTextMergeOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemTextMergeOp ReadAsPropertyName(
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
            return new SegmentTypeItemTextMergeOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemTextMergeOp value,
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

        public const string Contains = "contains";

        public const string Notcontain = "notcontain";

        public const string Starts = "starts";

        public const string Ends = "ends";

        public const string Greater = "greater";

        public const string Less = "less";

        public const string Blank = "blank";

        public const string BlankNot = "blank_not";
    }
}
