using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSurveyResponsesReportingResponseResponsesItemContactStatus.ListSurveyResponsesReportingResponseResponsesItemContactStatusSerializer)
)]
[Serializable]
public readonly record struct ListSurveyResponsesReportingResponseResponsesItemContactStatus
    : IStringEnum
{
    public static readonly ListSurveyResponsesReportingResponseResponsesItemContactStatus Subscribed =
        new(Values.Subscribed);

    public static readonly ListSurveyResponsesReportingResponseResponsesItemContactStatus Unsubscribed =
        new(Values.Unsubscribed);

    public static readonly ListSurveyResponsesReportingResponseResponsesItemContactStatus NonSubscribed =
        new(Values.NonSubscribed);

    public static readonly ListSurveyResponsesReportingResponseResponsesItemContactStatus Cleaned =
        new(Values.Cleaned);

    public static readonly ListSurveyResponsesReportingResponseResponsesItemContactStatus Archived =
        new(Values.Archived);

    public ListSurveyResponsesReportingResponseResponsesItemContactStatus(string value)
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
    public static ListSurveyResponsesReportingResponseResponsesItemContactStatus FromCustom(
        string value
    )
    {
        return new ListSurveyResponsesReportingResponseResponsesItemContactStatus(value);
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
        ListSurveyResponsesReportingResponseResponsesItemContactStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSurveyResponsesReportingResponseResponsesItemContactStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListSurveyResponsesReportingResponseResponsesItemContactStatus value
    ) => value.Value;

    public static explicit operator ListSurveyResponsesReportingResponseResponsesItemContactStatus(
        string value
    ) => new(value);

    internal class ListSurveyResponsesReportingResponseResponsesItemContactStatusSerializer
        : JsonConverter<ListSurveyResponsesReportingResponseResponsesItemContactStatus>
    {
        public override ListSurveyResponsesReportingResponseResponsesItemContactStatus Read(
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
            return new ListSurveyResponsesReportingResponseResponsesItemContactStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSurveyResponsesReportingResponseResponsesItemContactStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSurveyResponsesReportingResponseResponsesItemContactStatus ReadAsPropertyName(
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
            return new ListSurveyResponsesReportingResponseResponsesItemContactStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSurveyResponsesReportingResponseResponsesItemContactStatus value,
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
