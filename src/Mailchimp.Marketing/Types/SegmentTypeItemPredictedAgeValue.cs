using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemPredictedAgeValue.SegmentTypeItemPredictedAgeValueSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemPredictedAgeValue : IStringEnum
{
    public static readonly SegmentTypeItemPredictedAgeValue Eighteen24 = new(Values.Eighteen24);

    public static readonly SegmentTypeItemPredictedAgeValue TwentyFive34 = new(Values.TwentyFive34);

    public static readonly SegmentTypeItemPredictedAgeValue ThirtyFive44 = new(Values.ThirtyFive44);

    public static readonly SegmentTypeItemPredictedAgeValue FortyFive54 = new(Values.FortyFive54);

    public static readonly SegmentTypeItemPredictedAgeValue FiftyFive64 = new(Values.FiftyFive64);

    public static readonly SegmentTypeItemPredictedAgeValue SixtyFive = new(Values.SixtyFive);

    public SegmentTypeItemPredictedAgeValue(string value)
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
    public static SegmentTypeItemPredictedAgeValue FromCustom(string value)
    {
        return new SegmentTypeItemPredictedAgeValue(value);
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

    public static bool operator ==(SegmentTypeItemPredictedAgeValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemPredictedAgeValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemPredictedAgeValue value) => value.Value;

    public static explicit operator SegmentTypeItemPredictedAgeValue(string value) => new(value);

    internal class SegmentTypeItemPredictedAgeValueSerializer
        : JsonConverter<SegmentTypeItemPredictedAgeValue>
    {
        public override SegmentTypeItemPredictedAgeValue Read(
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
            return new SegmentTypeItemPredictedAgeValue(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemPredictedAgeValue value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemPredictedAgeValue ReadAsPropertyName(
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
            return new SegmentTypeItemPredictedAgeValue(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemPredictedAgeValue value,
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

        public const string ThirtyFive44 = "35-44";

        public const string FortyFive54 = "45-54";

        public const string FiftyFive64 = "55-64";

        public const string SixtyFive = "65+";
    }
}
