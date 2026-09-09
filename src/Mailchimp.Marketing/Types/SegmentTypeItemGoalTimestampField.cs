using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemGoalTimestampField.SegmentTypeItemGoalTimestampFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemGoalTimestampField : IStringEnum
{
    public static readonly SegmentTypeItemGoalTimestampField GoalLastVisited = new(
        Values.GoalLastVisited
    );

    public SegmentTypeItemGoalTimestampField(string value)
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
    public static SegmentTypeItemGoalTimestampField FromCustom(string value)
    {
        return new SegmentTypeItemGoalTimestampField(value);
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

    public static bool operator ==(SegmentTypeItemGoalTimestampField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemGoalTimestampField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemGoalTimestampField value) => value.Value;

    public static explicit operator SegmentTypeItemGoalTimestampField(string value) => new(value);

    internal class SegmentTypeItemGoalTimestampFieldSerializer
        : JsonConverter<SegmentTypeItemGoalTimestampField>
    {
        public override SegmentTypeItemGoalTimestampField Read(
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
            return new SegmentTypeItemGoalTimestampField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemGoalTimestampField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemGoalTimestampField ReadAsPropertyName(
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
            return new SegmentTypeItemGoalTimestampField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemGoalTimestampField value,
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
        public const string GoalLastVisited = "goal_last_visited";
    }
}
