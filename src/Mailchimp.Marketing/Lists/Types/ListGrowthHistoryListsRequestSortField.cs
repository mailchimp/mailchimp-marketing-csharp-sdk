using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListGrowthHistoryListsRequestSortField.ListGrowthHistoryListsRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListGrowthHistoryListsRequestSortField : IStringEnum
{
    public static readonly ListGrowthHistoryListsRequestSortField Month = new(Values.Month);

    public ListGrowthHistoryListsRequestSortField(string value)
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
    public static ListGrowthHistoryListsRequestSortField FromCustom(string value)
    {
        return new ListGrowthHistoryListsRequestSortField(value);
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

    public static bool operator ==(ListGrowthHistoryListsRequestSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListGrowthHistoryListsRequestSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListGrowthHistoryListsRequestSortField value) =>
        value.Value;

    public static explicit operator ListGrowthHistoryListsRequestSortField(string value) =>
        new(value);

    internal class ListGrowthHistoryListsRequestSortFieldSerializer
        : JsonConverter<ListGrowthHistoryListsRequestSortField>
    {
        public override ListGrowthHistoryListsRequestSortField Read(
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
            return new ListGrowthHistoryListsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListGrowthHistoryListsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListGrowthHistoryListsRequestSortField ReadAsPropertyName(
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
            return new ListGrowthHistoryListsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListGrowthHistoryListsRequestSortField value,
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
        public const string Month = "month";
    }
}
