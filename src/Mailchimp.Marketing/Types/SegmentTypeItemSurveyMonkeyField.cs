using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSurveyMonkeyField.SegmentTypeItemSurveyMonkeyFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSurveyMonkeyField : IStringEnum
{
    public static readonly SegmentTypeItemSurveyMonkeyField SurveyMonkey = new(Values.SurveyMonkey);

    public SegmentTypeItemSurveyMonkeyField(string value)
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
    public static SegmentTypeItemSurveyMonkeyField FromCustom(string value)
    {
        return new SegmentTypeItemSurveyMonkeyField(value);
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

    public static bool operator ==(SegmentTypeItemSurveyMonkeyField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSurveyMonkeyField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSurveyMonkeyField value) => value.Value;

    public static explicit operator SegmentTypeItemSurveyMonkeyField(string value) => new(value);

    internal class SegmentTypeItemSurveyMonkeyFieldSerializer
        : JsonConverter<SegmentTypeItemSurveyMonkeyField>
    {
        public override SegmentTypeItemSurveyMonkeyField Read(
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
            return new SegmentTypeItemSurveyMonkeyField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSurveyMonkeyField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSurveyMonkeyField ReadAsPropertyName(
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
            return new SegmentTypeItemSurveyMonkeyField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSurveyMonkeyField value,
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
        public const string SurveyMonkey = "survey_monkey";
    }
}
