using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemDateOp.SegmentTypeItemDateOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemDateOp : IStringEnum
{
    public static readonly SegmentTypeItemDateOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemDateOp Less = new(Values.Less);

    public static readonly SegmentTypeItemDateOp Is = new(Values.Is);

    public static readonly SegmentTypeItemDateOp Not = new(Values.Not);

    public static readonly SegmentTypeItemDateOp Blank = new(Values.Blank);

    public static readonly SegmentTypeItemDateOp BlankNot = new(Values.BlankNot);

    public static readonly SegmentTypeItemDateOp Within = new(Values.Within);

    public static readonly SegmentTypeItemDateOp Notwithin = new(Values.Notwithin);

    public SegmentTypeItemDateOp(string value)
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
    public static SegmentTypeItemDateOp FromCustom(string value)
    {
        return new SegmentTypeItemDateOp(value);
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

    public static bool operator ==(SegmentTypeItemDateOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemDateOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemDateOp value) => value.Value;

    public static explicit operator SegmentTypeItemDateOp(string value) => new(value);

    internal class SegmentTypeItemDateOpSerializer : JsonConverter<SegmentTypeItemDateOp>
    {
        public override SegmentTypeItemDateOp Read(
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
            return new SegmentTypeItemDateOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemDateOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemDateOp ReadAsPropertyName(
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
            return new SegmentTypeItemDateOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemDateOp value,
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
        public const string Greater = "greater";

        public const string Less = "less";

        public const string Is = "is";

        public const string Not = "not";

        public const string Blank = "blank";

        public const string BlankNot = "blank_not";

        public const string Within = "within";

        public const string Notwithin = "notwithin";
    }
}
