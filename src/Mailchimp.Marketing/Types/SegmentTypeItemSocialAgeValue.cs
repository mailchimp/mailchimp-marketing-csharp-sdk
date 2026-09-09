using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSocialAgeValue.SegmentTypeItemSocialAgeValueSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSocialAgeValue : IStringEnum
{
    public static readonly SegmentTypeItemSocialAgeValue Eighteen24 = new(Values.Eighteen24);

    public static readonly SegmentTypeItemSocialAgeValue TwentyFive34 = new(Values.TwentyFive34);

    public static readonly SegmentTypeItemSocialAgeValue ThirtyFive54 = new(Values.ThirtyFive54);

    public static readonly SegmentTypeItemSocialAgeValue FiftyFive = new(Values.FiftyFive);

    public SegmentTypeItemSocialAgeValue(string value)
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
    public static SegmentTypeItemSocialAgeValue FromCustom(string value)
    {
        return new SegmentTypeItemSocialAgeValue(value);
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

    public static bool operator ==(SegmentTypeItemSocialAgeValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialAgeValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialAgeValue value) => value.Value;

    public static explicit operator SegmentTypeItemSocialAgeValue(string value) => new(value);

    internal class SegmentTypeItemSocialAgeValueSerializer
        : JsonConverter<SegmentTypeItemSocialAgeValue>
    {
        public override SegmentTypeItemSocialAgeValue Read(
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
            return new SegmentTypeItemSocialAgeValue(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialAgeValue value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialAgeValue ReadAsPropertyName(
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
            return new SegmentTypeItemSocialAgeValue(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialAgeValue value,
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
        public const string Eighteen24 = "18-24";

        public const string TwentyFive34 = "25-34";

        public const string ThirtyFive54 = "35-54";

        public const string FiftyFive = "55+";
    }
}
