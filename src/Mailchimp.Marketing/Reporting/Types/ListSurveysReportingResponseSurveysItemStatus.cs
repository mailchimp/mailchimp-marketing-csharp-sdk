using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListSurveysReportingResponseSurveysItemStatus.ListSurveysReportingResponseSurveysItemStatusSerializer)
)]
[Serializable]
public readonly record struct ListSurveysReportingResponseSurveysItemStatus : IStringEnum
{
    public static readonly ListSurveysReportingResponseSurveysItemStatus Published = new(
        Values.Published
    );

    public static readonly ListSurveysReportingResponseSurveysItemStatus Unpublished = new(
        Values.Unpublished
    );

    public ListSurveysReportingResponseSurveysItemStatus(string value)
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
    public static ListSurveysReportingResponseSurveysItemStatus FromCustom(string value)
    {
        return new ListSurveysReportingResponseSurveysItemStatus(value);
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
        ListSurveysReportingResponseSurveysItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListSurveysReportingResponseSurveysItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListSurveysReportingResponseSurveysItemStatus value) =>
        value.Value;

    public static explicit operator ListSurveysReportingResponseSurveysItemStatus(string value) =>
        new(value);

    internal class ListSurveysReportingResponseSurveysItemStatusSerializer
        : JsonConverter<ListSurveysReportingResponseSurveysItemStatus>
    {
        public override ListSurveysReportingResponseSurveysItemStatus Read(
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
            return new ListSurveysReportingResponseSurveysItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListSurveysReportingResponseSurveysItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListSurveysReportingResponseSurveysItemStatus ReadAsPropertyName(
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
            return new ListSurveysReportingResponseSurveysItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListSurveysReportingResponseSurveysItemStatus value,
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
