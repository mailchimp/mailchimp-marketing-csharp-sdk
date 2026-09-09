using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(GetSurveyReportingResponseStatus.GetSurveyReportingResponseStatusSerializer))]
[Serializable]
public readonly record struct GetSurveyReportingResponseStatus : IStringEnum
{
    public static readonly GetSurveyReportingResponseStatus Published = new(Values.Published);

    public static readonly GetSurveyReportingResponseStatus Unpublished = new(Values.Unpublished);

    public GetSurveyReportingResponseStatus(string value)
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
    public static GetSurveyReportingResponseStatus FromCustom(string value)
    {
        return new GetSurveyReportingResponseStatus(value);
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

    public static bool operator ==(GetSurveyReportingResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetSurveyReportingResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetSurveyReportingResponseStatus value) => value.Value;

    public static explicit operator GetSurveyReportingResponseStatus(string value) => new(value);

    internal class GetSurveyReportingResponseStatusSerializer
        : JsonConverter<GetSurveyReportingResponseStatus>
    {
        public override GetSurveyReportingResponseStatus Read(
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
            return new GetSurveyReportingResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetSurveyReportingResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetSurveyReportingResponseStatus ReadAsPropertyName(
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
            return new GetSurveyReportingResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetSurveyReportingResponseStatus value,
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
        public const string Published = "published";

        public const string Unpublished = "unpublished";
    }
}
