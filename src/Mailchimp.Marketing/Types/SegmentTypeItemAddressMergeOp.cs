using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemAddressMergeOp.SegmentTypeItemAddressMergeOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemAddressMergeOp : IStringEnum
{
    public static readonly SegmentTypeItemAddressMergeOp Contains = new(Values.Contains);

    public static readonly SegmentTypeItemAddressMergeOp Notcontain = new(Values.Notcontain);

    public static readonly SegmentTypeItemAddressMergeOp Blank = new(Values.Blank);

    public static readonly SegmentTypeItemAddressMergeOp BlankNot = new(Values.BlankNot);

    public SegmentTypeItemAddressMergeOp(string value)
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
    public static SegmentTypeItemAddressMergeOp FromCustom(string value)
    {
        return new SegmentTypeItemAddressMergeOp(value);
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

    public static bool operator ==(SegmentTypeItemAddressMergeOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemAddressMergeOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemAddressMergeOp value) => value.Value;

    public static explicit operator SegmentTypeItemAddressMergeOp(string value) => new(value);

    internal class SegmentTypeItemAddressMergeOpSerializer
        : JsonConverter<SegmentTypeItemAddressMergeOp>
    {
        public override SegmentTypeItemAddressMergeOp Read(
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
            return new SegmentTypeItemAddressMergeOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemAddressMergeOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemAddressMergeOp ReadAsPropertyName(
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
            return new SegmentTypeItemAddressMergeOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemAddressMergeOp value,
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
        public const string Contains = "contains";

        public const string Notcontain = "notcontain";

        public const string Blank = "blank";

        public const string BlankNot = "blank_not";
    }
}
