using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(GetSurveyResponsReportingResponseContactStatus.GetSurveyResponsReportingResponseContactStatusSerializer)
)]
[Serializable]
public readonly record struct GetSurveyResponsReportingResponseContactStatus : IStringEnum
{
    public static readonly GetSurveyResponsReportingResponseContactStatus Subscribed = new(
        Values.Subscribed
    );

    public static readonly GetSurveyResponsReportingResponseContactStatus Unsubscribed = new(
        Values.Unsubscribed
    );

    public static readonly GetSurveyResponsReportingResponseContactStatus NonSubscribed = new(
        Values.NonSubscribed
    );

    public static readonly GetSurveyResponsReportingResponseContactStatus Cleaned = new(
        Values.Cleaned
    );

    public static readonly GetSurveyResponsReportingResponseContactStatus Archived = new(
        Values.Archived
    );

    public GetSurveyResponsReportingResponseContactStatus(string value)
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
    public static GetSurveyResponsReportingResponseContactStatus FromCustom(string value)
    {
        return new GetSurveyResponsReportingResponseContactStatus(value);
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
        GetSurveyResponsReportingResponseContactStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetSurveyResponsReportingResponseContactStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetSurveyResponsReportingResponseContactStatus value) =>
        value.Value;

    public static explicit operator GetSurveyResponsReportingResponseContactStatus(string value) =>
        new(value);

    internal class GetSurveyResponsReportingResponseContactStatusSerializer
        : JsonConverter<GetSurveyResponsReportingResponseContactStatus>
    {
        public override GetSurveyResponsReportingResponseContactStatus Read(
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
            return new GetSurveyResponsReportingResponseContactStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetSurveyResponsReportingResponseContactStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetSurveyResponsReportingResponseContactStatus ReadAsPropertyName(
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
            return new GetSurveyResponsReportingResponseContactStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetSurveyResponsReportingResponseContactStatus value,
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
