using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFacebookAdEcommerceProductActivityReportingRequestSortField.ListFacebookAdEcommerceProductActivityReportingRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListFacebookAdEcommerceProductActivityReportingRequestSortField
    : IStringEnum
{
    public static readonly ListFacebookAdEcommerceProductActivityReportingRequestSortField Title =
        new(Values.Title);

    public static readonly ListFacebookAdEcommerceProductActivityReportingRequestSortField TotalRevenue =
        new(Values.TotalRevenue);

    public static readonly ListFacebookAdEcommerceProductActivityReportingRequestSortField TotalPurchased =
        new(Values.TotalPurchased);

    public ListFacebookAdEcommerceProductActivityReportingRequestSortField(string value)
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
    public static ListFacebookAdEcommerceProductActivityReportingRequestSortField FromCustom(
        string value
    )
    {
        return new ListFacebookAdEcommerceProductActivityReportingRequestSortField(value);
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
        ListFacebookAdEcommerceProductActivityReportingRequestSortField value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListFacebookAdEcommerceProductActivityReportingRequestSortField value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListFacebookAdEcommerceProductActivityReportingRequestSortField value
    ) => value.Value;

    public static explicit operator ListFacebookAdEcommerceProductActivityReportingRequestSortField(
        string value
    ) => new(value);

    internal class ListFacebookAdEcommerceProductActivityReportingRequestSortFieldSerializer
        : JsonConverter<ListFacebookAdEcommerceProductActivityReportingRequestSortField>
    {
        public override ListFacebookAdEcommerceProductActivityReportingRequestSortField Read(
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
            return new ListFacebookAdEcommerceProductActivityReportingRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFacebookAdEcommerceProductActivityReportingRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFacebookAdEcommerceProductActivityReportingRequestSortField ReadAsPropertyName(
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
            return new ListFacebookAdEcommerceProductActivityReportingRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFacebookAdEcommerceProductActivityReportingRequestSortField value,
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
        public const string Title = "title";

        public const string TotalRevenue = "total_revenue";

        public const string TotalPurchased = "total_purchased";
    }
}
