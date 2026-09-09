using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemBirthdayMergeOp.SegmentTypeItemBirthdayMergeOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemBirthdayMergeOp : IStringEnum
{
    public static readonly SegmentTypeItemBirthdayMergeOp Is = new(Values.Is);

    public static readonly SegmentTypeItemBirthdayMergeOp Not = new(Values.Not);

    public static readonly SegmentTypeItemBirthdayMergeOp Blank = new(Values.Blank);

    public static readonly SegmentTypeItemBirthdayMergeOp BlankNot = new(Values.BlankNot);

    public SegmentTypeItemBirthdayMergeOp(string value)
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
    public static SegmentTypeItemBirthdayMergeOp FromCustom(string value)
    {
        return new SegmentTypeItemBirthdayMergeOp(value);
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

    public static bool operator ==(SegmentTypeItemBirthdayMergeOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemBirthdayMergeOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemBirthdayMergeOp value) => value.Value;

    public static explicit operator SegmentTypeItemBirthdayMergeOp(string value) => new(value);

    internal class SegmentTypeItemBirthdayMergeOpSerializer
        : JsonConverter<SegmentTypeItemBirthdayMergeOp>
    {
        public override SegmentTypeItemBirthdayMergeOp Read(
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
            return new SegmentTypeItemBirthdayMergeOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemBirthdayMergeOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemBirthdayMergeOp ReadAsPropertyName(
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
            return new SegmentTypeItemBirthdayMergeOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemBirthdayMergeOp value,
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
    }
}
