using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSurveyMonkeyOp.SegmentTypeItemSurveyMonkeyOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSurveyMonkeyOp : IStringEnum
{
    public static readonly SegmentTypeItemSurveyMonkeyOp Started = new(Values.Started);

    public static readonly SegmentTypeItemSurveyMonkeyOp Completed = new(Values.Completed);

    public static readonly SegmentTypeItemSurveyMonkeyOp NotStarted = new(Values.NotStarted);

    public static readonly SegmentTypeItemSurveyMonkeyOp NotCompleted = new(Values.NotCompleted);

    public SegmentTypeItemSurveyMonkeyOp(string value)
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
    public static SegmentTypeItemSurveyMonkeyOp FromCustom(string value)
    {
        return new SegmentTypeItemSurveyMonkeyOp(value);
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

    public static bool operator ==(SegmentTypeItemSurveyMonkeyOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSurveyMonkeyOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSurveyMonkeyOp value) => value.Value;

    public static explicit operator SegmentTypeItemSurveyMonkeyOp(string value) => new(value);

    internal class SegmentTypeItemSurveyMonkeyOpSerializer
        : JsonConverter<SegmentTypeItemSurveyMonkeyOp>
    {
        public override SegmentTypeItemSurveyMonkeyOp Read(
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
            return new SegmentTypeItemSurveyMonkeyOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSurveyMonkeyOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSurveyMonkeyOp ReadAsPropertyName(
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
            return new SegmentTypeItemSurveyMonkeyOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSurveyMonkeyOp value,
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
