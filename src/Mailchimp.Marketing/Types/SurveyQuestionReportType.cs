using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SurveyQuestionReportType.SurveyQuestionReportTypeSerializer))]
[Serializable]
public readonly record struct SurveyQuestionReportType : IStringEnum
{
    public static readonly SurveyQuestionReportType PickOne = new(Values.PickOne);

    public static readonly SurveyQuestionReportType PickMany = new(Values.PickMany);

    public static readonly SurveyQuestionReportType Range = new(Values.Range);

    public static readonly SurveyQuestionReportType Text = new(Values.Text);

    public static readonly SurveyQuestionReportType Email = new(Values.Email);

    public static readonly SurveyQuestionReportType ContactInformation = new(
        Values.ContactInformation
    );

    public static readonly SurveyQuestionReportType Dropdown = new(Values.Dropdown);

    public SurveyQuestionReportType(string value)
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
    public static SurveyQuestionReportType FromCustom(string value)
    {
        return new SurveyQuestionReportType(value);
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

    public static bool operator ==(SurveyQuestionReportType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SurveyQuestionReportType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SurveyQuestionReportType value) => value.Value;

    public static explicit operator SurveyQuestionReportType(string value) => new(value);

    internal class SurveyQuestionReportTypeSerializer : JsonConverter<SurveyQuestionReportType>
    {
        public override SurveyQuestionReportType Read(
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
            return new SurveyQuestionReportType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SurveyQuestionReportType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SurveyQuestionReportType ReadAsPropertyName(
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
            return new SurveyQuestionReportType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SurveyQuestionReportType value,
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
        public const string PickOne = "pickOne";

        public const string PickMany = "pickMany";

        public const string Range = "range";

        public const string Text = "text";

        public const string Email = "email";

        public const string ContactInformation = "contactInformation";

        public const string Dropdown = "dropdown";
    }
}
