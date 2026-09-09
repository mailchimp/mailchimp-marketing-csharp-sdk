using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFacebookAdsReportingRequestSortField.ListFacebookAdsReportingRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListFacebookAdsReportingRequestSortField : IStringEnum
{
    public static readonly ListFacebookAdsReportingRequestSortField CreatedAt = new(
        Values.CreatedAt
    );

    public static readonly ListFacebookAdsReportingRequestSortField UpdatedAt = new(
        Values.UpdatedAt
    );

    public static readonly ListFacebookAdsReportingRequestSortField EndTime = new(Values.EndTime);

    public ListFacebookAdsReportingRequestSortField(string value)
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
    public static ListFacebookAdsReportingRequestSortField FromCustom(string value)
    {
        return new ListFacebookAdsReportingRequestSortField(value);
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
        ListFacebookAdsReportingRequestSortField value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListFacebookAdsReportingRequestSortField value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListFacebookAdsReportingRequestSortField value) =>
        value.Value;

    public static explicit operator ListFacebookAdsReportingRequestSortField(string value) =>
        new(value);

    internal class ListFacebookAdsReportingRequestSortFieldSerializer
        : JsonConverter<ListFacebookAdsReportingRequestSortField>
    {
        public override ListFacebookAdsReportingRequestSortField Read(
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
            return new ListFacebookAdsReportingRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFacebookAdsReportingRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFacebookAdsReportingRequestSortField ReadAsPropertyName(
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
            return new ListFacebookAdsReportingRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFacebookAdsReportingRequestSortField value,
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
        public const string CreatedAt = "created_at";

        public const string UpdatedAt = "updated_at";

        public const string EndTime = "end_time";
    }
}
