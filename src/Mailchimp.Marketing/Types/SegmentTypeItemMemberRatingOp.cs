using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemMemberRatingOp.SegmentTypeItemMemberRatingOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemMemberRatingOp : IStringEnum
{
    public static readonly SegmentTypeItemMemberRatingOp Is = new(Values.Is);

    public static readonly SegmentTypeItemMemberRatingOp Not = new(Values.Not);

    public static readonly SegmentTypeItemMemberRatingOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemMemberRatingOp Less = new(Values.Less);

    public SegmentTypeItemMemberRatingOp(string value)
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
    public static SegmentTypeItemMemberRatingOp FromCustom(string value)
    {
        return new SegmentTypeItemMemberRatingOp(value);
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

    public static bool operator ==(SegmentTypeItemMemberRatingOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemMemberRatingOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemMemberRatingOp value) => value.Value;

    public static explicit operator SegmentTypeItemMemberRatingOp(string value) => new(value);

    internal class SegmentTypeItemMemberRatingOpSerializer
        : JsonConverter<SegmentTypeItemMemberRatingOp>
    {
        public override SegmentTypeItemMemberRatingOp Read(
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
            return new SegmentTypeItemMemberRatingOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemMemberRatingOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemMemberRatingOp ReadAsPropertyName(
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
            return new SegmentTypeItemMemberRatingOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemMemberRatingOp value,
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

        public const string Greater = "greater";

        public const string Less = "less";
    }
}
