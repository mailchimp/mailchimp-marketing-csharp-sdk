using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSurveyResponsesReportingRequestRespondentFamiliarityIs.ListSurveyResponsesReportingRequestRespondentFamiliarityIsSerializer)
)]
[Serializable]
public readonly record struct ListSurveyResponsesReportingRequestRespondentFamiliarityIs
    : IStringEnum
{
    public static readonly ListSurveyResponsesReportingRequestRespondentFamiliarityIs New = new(
        Values.New
    );

    public static readonly ListSurveyResponsesReportingRequestRespondentFamiliarityIs Known = new(
        Values.Known
    );

    public static readonly ListSurveyResponsesReportingRequestRespondentFamiliarityIs Unknown = new(
        Values.Unknown
    );

    public ListSurveyResponsesReportingRequestRespondentFamiliarityIs(string value)
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
    public static ListSurveyResponsesReportingRequestRespondentFamiliarityIs FromCustom(
        string value
    )
    {
        return new ListSurveyResponsesReportingRequestRespondentFamiliarityIs(value);
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
        ListSurveyResponsesReportingRequestRespondentFamiliarityIs value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSurveyResponsesReportingRequestRespondentFamiliarityIs value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListSurveyResponsesReportingRequestRespondentFamiliarityIs value
    ) => value.Value;

    public static explicit operator ListSurveyResponsesReportingRequestRespondentFamiliarityIs(
        string value
    ) => new(value);

    internal class ListSurveyResponsesReportingRequestRespondentFamiliarityIsSerializer
        : JsonConverter<ListSurveyResponsesReportingRequestRespondentFamiliarityIs>
    {
        public override ListSurveyResponsesReportingRequestRespondentFamiliarityIs Read(
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
            return new ListSurveyResponsesReportingRequestRespondentFamiliarityIs(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSurveyResponsesReportingRequestRespondentFamiliarityIs value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSurveyResponsesReportingRequestRespondentFamiliarityIs ReadAsPropertyName(
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
            return new ListSurveyResponsesReportingRequestRespondentFamiliarityIs(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSurveyResponsesReportingRequestRespondentFamiliarityIs value,
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
