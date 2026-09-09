using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSelectMergeOp.SegmentTypeItemSelectMergeOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSelectMergeOp : IStringEnum
{
    public static readonly SegmentTypeItemSelectMergeOp Is = new(Values.Is);

    public static readonly SegmentTypeItemSelectMergeOp Not = new(Values.Not);

    public static readonly SegmentTypeItemSelectMergeOp Blank = new(Values.Blank);

    public static readonly SegmentTypeItemSelectMergeOp BlankNot = new(Values.BlankNot);

    public static readonly SegmentTypeItemSelectMergeOp Notcontain = new(Values.Notcontain);

    public static readonly SegmentTypeItemSelectMergeOp Contains = new(Values.Contains);

    public SegmentTypeItemSelectMergeOp(string value)
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
    public static SegmentTypeItemSelectMergeOp FromCustom(string value)
    {
        return new SegmentTypeItemSelectMergeOp(value);
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

    public static bool operator ==(SegmentTypeItemSelectMergeOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSelectMergeOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSelectMergeOp value) => value.Value;

    public static explicit operator SegmentTypeItemSelectMergeOp(string value) => new(value);

    internal class SegmentTypeItemSelectMergeOpSerializer
        : JsonConverter<SegmentTypeItemSelectMergeOp>
    {
        public override SegmentTypeItemSelectMergeOp Read(
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
            return new SegmentTypeItemSelectMergeOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSelectMergeOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSelectMergeOp ReadAsPropertyName(
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
            return new SegmentTypeItemSelectMergeOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSelectMergeOp value,
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

        public const string Blank = "blank";

        public const string BlankNot = "blank_not";

        public const string Notcontain = "notcontain";

        public const string Contains = "contains";
    }
}
