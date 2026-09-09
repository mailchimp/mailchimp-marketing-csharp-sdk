using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus.ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatusSerializer)
)]
[Serializable]
public readonly record struct ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus
    : IStringEnum
{
    public static readonly ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus Subscribed =
        new(Values.Subscribed);

    public static readonly ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus Unsubscribed =
        new(Values.Unsubscribed);

    public static readonly ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus NonSubscribed =
        new(Values.NonSubscribed);

    public static readonly ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus Cleaned =
        new(Values.Cleaned);

    public static readonly ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus Archived =
        new(Values.Archived);

    public ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus(string value)
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
    public static ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus FromCustom(
        string value
    )
    {
        return new ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus(value);
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
        ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus value
    ) => value.Value;

    public static explicit operator ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus(
        string value
    ) => new(value);

    internal class ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatusSerializer
        : JsonConverter<ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus>
    {
        public override ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus Read(
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
            return new ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus ReadAsPropertyName(
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
            return new ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSurveyQuestionAnswersReportingResponseAnswersItemContactStatus value,
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
        public const string Subscribed = "Subscribed";

        public const string Unsubscribed = "Unsubscribed";

        public const string NonSubscribed = "Non-Subscribed";

        public const string Cleaned = "Cleaned";

        public const string Archived = "Archived";
    }
}
