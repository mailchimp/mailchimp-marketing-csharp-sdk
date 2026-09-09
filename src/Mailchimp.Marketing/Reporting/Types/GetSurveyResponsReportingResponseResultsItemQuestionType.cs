using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(GetSurveyResponsReportingResponseResultsItemQuestionType.GetSurveyResponsReportingResponseResultsItemQuestionTypeSerializer)
)]
[Serializable]
public readonly record struct GetSurveyResponsReportingResponseResultsItemQuestionType : IStringEnum
{
    public static readonly GetSurveyResponsReportingResponseResultsItemQuestionType PickOne = new(
        Values.PickOne
    );

    public static readonly GetSurveyResponsReportingResponseResultsItemQuestionType PickMany = new(
        Values.PickMany
    );

    public static readonly GetSurveyResponsReportingResponseResultsItemQuestionType Range = new(
        Values.Range
    );

    public static readonly GetSurveyResponsReportingResponseResultsItemQuestionType Text = new(
        Values.Text
    );

    public static readonly GetSurveyResponsReportingResponseResultsItemQuestionType Email = new(
        Values.Email
    );

    public static readonly GetSurveyResponsReportingResponseResultsItemQuestionType ContactInformation =
        new(Values.ContactInformation);

    public static readonly GetSurveyResponsReportingResponseResultsItemQuestionType Dropdown = new(
        Values.Dropdown
    );

    public GetSurveyResponsReportingResponseResultsItemQuestionType(string value)
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
    public static GetSurveyResponsReportingResponseResultsItemQuestionType FromCustom(string value)
    {
        return new GetSurveyResponsReportingResponseResultsItemQuestionType(value);
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
        GetSurveyResponsReportingResponseResultsItemQuestionType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetSurveyResponsReportingResponseResultsItemQuestionType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GetSurveyResponsReportingResponseResultsItemQuestionType value
    ) => value.Value;

    public static explicit operator GetSurveyResponsReportingResponseResultsItemQuestionType(
        string value
    ) => new(value);

    internal class GetSurveyResponsReportingResponseResultsItemQuestionTypeSerializer
        : JsonConverter<GetSurveyResponsReportingResponseResultsItemQuestionType>
    {
        public override GetSurveyResponsReportingResponseResultsItemQuestionType Read(
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
            return new GetSurveyResponsReportingResponseResultsItemQuestionType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetSurveyResponsReportingResponseResultsItemQuestionType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetSurveyResponsReportingResponseResultsItemQuestionType ReadAsPropertyName(
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
            return new GetSurveyResponsReportingResponseResultsItemQuestionType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetSurveyResponsReportingResponseResultsItemQuestionType value,
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
