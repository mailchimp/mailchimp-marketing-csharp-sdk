using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemGoalActivityOp.SegmentTypeItemGoalActivityOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemGoalActivityOp : IStringEnum
{
    public static readonly SegmentTypeItemGoalActivityOp Is = new(Values.Is);

    public static readonly SegmentTypeItemGoalActivityOp GoalNot = new(Values.GoalNot);

    public static readonly SegmentTypeItemGoalActivityOp Contains = new(Values.Contains);

    public static readonly SegmentTypeItemGoalActivityOp GoalNotcontain = new(
        Values.GoalNotcontain
    );

    public static readonly SegmentTypeItemGoalActivityOp Starts = new(Values.Starts);

    public static readonly SegmentTypeItemGoalActivityOp Ends = new(Values.Ends);

    public SegmentTypeItemGoalActivityOp(string value)
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
    public static SegmentTypeItemGoalActivityOp FromCustom(string value)
    {
        return new SegmentTypeItemGoalActivityOp(value);
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

    public static bool operator ==(SegmentTypeItemGoalActivityOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemGoalActivityOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemGoalActivityOp value) => value.Value;

    public static explicit operator SegmentTypeItemGoalActivityOp(string value) => new(value);

    internal class SegmentTypeItemGoalActivityOpSerializer
        : JsonConverter<SegmentTypeItemGoalActivityOp>
    {
        public override SegmentTypeItemGoalActivityOp Read(
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
            return new SegmentTypeItemGoalActivityOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemGoalActivityOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemGoalActivityOp ReadAsPropertyName(
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
            return new SegmentTypeItemGoalActivityOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemGoalActivityOp value,
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

        public const string GoalNot = "goal_not";

        public const string Contains = "contains";

        public const string GoalNotcontain = "goal_notcontain";

        public const string Starts = "starts";

        public const string Ends = "ends";
    }
}
