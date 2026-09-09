using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemGoalTimestampOp.SegmentTypeItemGoalTimestampOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemGoalTimestampOp : IStringEnum
{
    public static readonly SegmentTypeItemGoalTimestampOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemGoalTimestampOp Less = new(Values.Less);

    public static readonly SegmentTypeItemGoalTimestampOp Is = new(Values.Is);

    public SegmentTypeItemGoalTimestampOp(string value)
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
    public static SegmentTypeItemGoalTimestampOp FromCustom(string value)
    {
        return new SegmentTypeItemGoalTimestampOp(value);
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

    public static bool operator ==(SegmentTypeItemGoalTimestampOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemGoalTimestampOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemGoalTimestampOp value) => value.Value;

    public static explicit operator SegmentTypeItemGoalTimestampOp(string value) => new(value);

    internal class SegmentTypeItemGoalTimestampOpSerializer
        : JsonConverter<SegmentTypeItemGoalTimestampOp>
    {
        public override SegmentTypeItemGoalTimestampOp Read(
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
            return new SegmentTypeItemGoalTimestampOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemGoalTimestampOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemGoalTimestampOp ReadAsPropertyName(
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
            return new SegmentTypeItemGoalTimestampOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemGoalTimestampOp value,
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
    }
}
