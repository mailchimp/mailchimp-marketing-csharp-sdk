using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListEcommerceProductActivityReportsRequestSortField.ListEcommerceProductActivityReportsRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListEcommerceProductActivityReportsRequestSortField : IStringEnum
{
    public static readonly ListEcommerceProductActivityReportsRequestSortField Title = new(
        Values.Title
    );

    public static readonly ListEcommerceProductActivityReportsRequestSortField TotalRevenue = new(
        Values.TotalRevenue
    );

    public static readonly ListEcommerceProductActivityReportsRequestSortField TotalPurchased = new(
        Values.TotalPurchased
    );

    public ListEcommerceProductActivityReportsRequestSortField(string value)
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
    public static ListEcommerceProductActivityReportsRequestSortField FromCustom(string value)
    {
        return new ListEcommerceProductActivityReportsRequestSortField(value);
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
        ListEcommerceProductActivityReportsRequestSortField value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListEcommerceProductActivityReportsRequestSortField value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListEcommerceProductActivityReportsRequestSortField value
    ) => value.Value;

    public static explicit operator ListEcommerceProductActivityReportsRequestSortField(
        string value
    ) => new(value);

    internal class ListEcommerceProductActivityReportsRequestSortFieldSerializer
        : JsonConverter<ListEcommerceProductActivityReportsRequestSortField>
    {
        public override ListEcommerceProductActivityReportsRequestSortField Read(
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
            return new ListEcommerceProductActivityReportsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListEcommerceProductActivityReportsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListEcommerceProductActivityReportsRequestSortField ReadAsPropertyName(
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
            return new ListEcommerceProductActivityReportsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListEcommerceProductActivityReportsRequestSortField value,
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
