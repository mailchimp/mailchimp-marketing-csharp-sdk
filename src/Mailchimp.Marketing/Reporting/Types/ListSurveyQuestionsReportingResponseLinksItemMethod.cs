using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSurveyQuestionsReportingResponseLinksItemMethod.ListSurveyQuestionsReportingResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListSurveyQuestionsReportingResponseLinksItemMethod : IStringEnum
{
    public static readonly ListSurveyQuestionsReportingResponseLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListSurveyQuestionsReportingResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListSurveyQuestionsReportingResponseLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListSurveyQuestionsReportingResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListSurveyQuestionsReportingResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListSurveyQuestionsReportingResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListSurveyQuestionsReportingResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListSurveyQuestionsReportingResponseLinksItemMethod(string value)
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
    public static ListSurveyQuestionsReportingResponseLinksItemMethod FromCustom(string value)
    {
        return new ListSurveyQuestionsReportingResponseLinksItemMethod(value);
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
        ListSurveyQuestionsReportingResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSurveyQuestionsReportingResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListSurveyQuestionsReportingResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListSurveyQuestionsReportingResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListSurveyQuestionsReportingResponseLinksItemMethodSerializer
        : JsonConverter<ListSurveyQuestionsReportingResponseLinksItemMethod>
    {
        public override ListSurveyQuestionsReportingResponseLinksItemMethod Read(
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
            return new ListSurveyQuestionsReportingResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSurveyQuestionsReportingResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSurveyQuestionsReportingResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListSurveyQuestionsReportingResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSurveyQuestionsReportingResponseLinksItemMethod value,
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
        public const string Get = "GET";

        public const string Post = "POST";

        public const string Put = "PUT";

        public const string Patch = "PATCH";

        public const string Delete = "DELETE";

        public const string Options = "OPTIONS";

        public const string Head = "HEAD";
    }
}
