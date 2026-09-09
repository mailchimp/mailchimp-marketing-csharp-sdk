using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListFacebookAdsRequestSortField.ListFacebookAdsRequestSortFieldSerializer))]
[Serializable]
public readonly record struct ListFacebookAdsRequestSortField : IStringEnum
{
    public static readonly ListFacebookAdsRequestSortField CreatedAt = new(Values.CreatedAt);

    public static readonly ListFacebookAdsRequestSortField UpdatedAt = new(Values.UpdatedAt);

    public static readonly ListFacebookAdsRequestSortField EndTime = new(Values.EndTime);

    public ListFacebookAdsRequestSortField(string value)
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
    public static ListFacebookAdsRequestSortField FromCustom(string value)
    {
        return new ListFacebookAdsRequestSortField(value);
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

    public static bool operator ==(ListFacebookAdsRequestSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListFacebookAdsRequestSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListFacebookAdsRequestSortField value) => value.Value;

    public static explicit operator ListFacebookAdsRequestSortField(string value) => new(value);

    internal class ListFacebookAdsRequestSortFieldSerializer
        : JsonConverter<ListFacebookAdsRequestSortField>
    {
        public override ListFacebookAdsRequestSortField Read(
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
            return new ListFacebookAdsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFacebookAdsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFacebookAdsRequestSortField ReadAsPropertyName(
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
            return new ListFacebookAdsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFacebookAdsRequestSortField value,
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
