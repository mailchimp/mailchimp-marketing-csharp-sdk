using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemAutomationOp.SegmentTypeItemAutomationOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemAutomationOp : IStringEnum
{
    public static readonly SegmentTypeItemAutomationOp Started = new(Values.Started);

    public static readonly SegmentTypeItemAutomationOp Completed = new(Values.Completed);

    public static readonly SegmentTypeItemAutomationOp NotStarted = new(Values.NotStarted);

    public static readonly SegmentTypeItemAutomationOp NotCompleted = new(Values.NotCompleted);

    public SegmentTypeItemAutomationOp(string value)
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
    public static SegmentTypeItemAutomationOp FromCustom(string value)
    {
        return new SegmentTypeItemAutomationOp(value);
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

    public static bool operator ==(SegmentTypeItemAutomationOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemAutomationOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemAutomationOp value) => value.Value;

    public static explicit operator SegmentTypeItemAutomationOp(string value) => new(value);

    internal class SegmentTypeItemAutomationOpSerializer
        : JsonConverter<SegmentTypeItemAutomationOp>
    {
        public override SegmentTypeItemAutomationOp Read(
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
            return new SegmentTypeItemAutomationOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemAutomationOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemAutomationOp ReadAsPropertyName(
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
            return new SegmentTypeItemAutomationOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemAutomationOp value,
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
        public const string Started = "started";

        public const string Completed = "completed";

        public const string NotStarted = "not_started";

        public const string NotCompleted = "not_completed";
    }
}
