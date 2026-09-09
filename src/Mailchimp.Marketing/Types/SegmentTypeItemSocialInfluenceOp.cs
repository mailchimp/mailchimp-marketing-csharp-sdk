using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSocialInfluenceOp.SegmentTypeItemSocialInfluenceOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSocialInfluenceOp : IStringEnum
{
    public static readonly SegmentTypeItemSocialInfluenceOp Is = new(Values.Is);

    public static readonly SegmentTypeItemSocialInfluenceOp Not = new(Values.Not);

    public static readonly SegmentTypeItemSocialInfluenceOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemSocialInfluenceOp Less = new(Values.Less);

    public SegmentTypeItemSocialInfluenceOp(string value)
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
    public static SegmentTypeItemSocialInfluenceOp FromCustom(string value)
    {
        return new SegmentTypeItemSocialInfluenceOp(value);
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

    public static bool operator ==(SegmentTypeItemSocialInfluenceOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialInfluenceOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialInfluenceOp value) => value.Value;

    public static explicit operator SegmentTypeItemSocialInfluenceOp(string value) => new(value);

    internal class SegmentTypeItemSocialInfluenceOpSerializer
        : JsonConverter<SegmentTypeItemSocialInfluenceOp>
    {
        public override SegmentTypeItemSocialInfluenceOp Read(
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
            return new SegmentTypeItemSocialInfluenceOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialInfluenceOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialInfluenceOp ReadAsPropertyName(
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
            return new SegmentTypeItemSocialInfluenceOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialInfluenceOp value,
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
