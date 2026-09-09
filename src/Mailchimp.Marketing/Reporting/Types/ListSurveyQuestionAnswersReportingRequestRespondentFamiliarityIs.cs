using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs.ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIsSerializer)
)]
[Serializable]
public readonly record struct ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs
    : IStringEnum
{
    public static readonly ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs New =
        new(Values.New);

    public static readonly ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs Known =
        new(Values.Known);

    public static readonly ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs Unknown =
        new(Values.Unknown);

    public ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs(string value)
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
    public static ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs FromCustom(
        string value
    )
    {
        return new ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs(value);
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

    public static bool operator ==(
        ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs value
    ) => value.Value;

    public static explicit operator ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs(
        string value
    ) => new(value);

    internal class ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIsSerializer
        : JsonConverter<ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs>
    {
        public override ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs Read(
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
            return new ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs ReadAsPropertyName(
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
            return new ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs value,
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
        public const string New = "new";

        public const string Known = "known";

        public const string Unknown = "unknown";
    }
}
