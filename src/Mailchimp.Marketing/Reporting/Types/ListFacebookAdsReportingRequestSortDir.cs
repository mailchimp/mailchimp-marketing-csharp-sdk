using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFacebookAdsReportingRequestSortDir.ListFacebookAdsReportingRequestSortDirSerializer)
)]
[Serializable]
public readonly record struct ListFacebookAdsReportingRequestSortDir : IStringEnum
{
    public static readonly ListFacebookAdsReportingRequestSortDir Asc = new(Values.Asc);

    public static readonly ListFacebookAdsReportingRequestSortDir Desc = new(Values.Desc);

    public ListFacebookAdsReportingRequestSortDir(string value)
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
    public static ListFacebookAdsReportingRequestSortDir FromCustom(string value)
    {
        return new ListFacebookAdsReportingRequestSortDir(value);
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

    public static bool operator ==(ListFacebookAdsReportingRequestSortDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListFacebookAdsReportingRequestSortDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListFacebookAdsReportingRequestSortDir value) =>
        value.Value;

    public static explicit operator ListFacebookAdsReportingRequestSortDir(string value) =>
        new(value);

    internal class ListFacebookAdsReportingRequestSortDirSerializer
        : JsonConverter<ListFacebookAdsReportingRequestSortDir>
    {
        public override ListFacebookAdsReportingRequestSortDir Read(
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
            return new ListFacebookAdsReportingRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFacebookAdsReportingRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFacebookAdsReportingRequestSortDir ReadAsPropertyName(
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
            return new ListFacebookAdsReportingRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFacebookAdsReportingRequestSortDir value,
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
        public const string Asc = "ASC";

        public const string Desc = "DESC";
    }
}
