using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSurveysReportingResponseLinksItemMethod.ListSurveysReportingResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListSurveysReportingResponseLinksItemMethod : IStringEnum
{
    public static readonly ListSurveysReportingResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListSurveysReportingResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListSurveysReportingResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListSurveysReportingResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListSurveysReportingResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListSurveysReportingResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListSurveysReportingResponseLinksItemMethod Head = new(Values.Head);

    public ListSurveysReportingResponseLinksItemMethod(string value)
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
    public static ListSurveysReportingResponseLinksItemMethod FromCustom(string value)
    {
        return new ListSurveysReportingResponseLinksItemMethod(value);
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
        ListSurveysReportingResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSurveysReportingResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListSurveysReportingResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListSurveysReportingResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListSurveysReportingResponseLinksItemMethodSerializer
        : JsonConverter<ListSurveysReportingResponseLinksItemMethod>
    {
        public override ListSurveysReportingResponseLinksItemMethod Read(
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
            return new ListSurveysReportingResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSurveysReportingResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSurveysReportingResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListSurveysReportingResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSurveysReportingResponseLinksItemMethod value,
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
