using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListClickDetailsReportsRequestSortField.ListClickDetailsReportsRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListClickDetailsReportsRequestSortField : IStringEnum
{
    public static readonly ListClickDetailsReportsRequestSortField TotalClicks = new(
        Values.TotalClicks
    );

    public static readonly ListClickDetailsReportsRequestSortField UniqueClicks = new(
        Values.UniqueClicks
    );

    public ListClickDetailsReportsRequestSortField(string value)
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
    public static ListClickDetailsReportsRequestSortField FromCustom(string value)
    {
        return new ListClickDetailsReportsRequestSortField(value);
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

    public static bool operator ==(ListClickDetailsReportsRequestSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListClickDetailsReportsRequestSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListClickDetailsReportsRequestSortField value) =>
        value.Value;

    public static explicit operator ListClickDetailsReportsRequestSortField(string value) =>
        new(value);

    internal class ListClickDetailsReportsRequestSortFieldSerializer
        : JsonConverter<ListClickDetailsReportsRequestSortField>
    {
        public override ListClickDetailsReportsRequestSortField Read(
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
            return new ListClickDetailsReportsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListClickDetailsReportsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListClickDetailsReportsRequestSortField ReadAsPropertyName(
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
            return new ListClickDetailsReportsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListClickDetailsReportsRequestSortField value,
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
        public const string TotalClicks = "total_clicks";

        public const string UniqueClicks = "unique_clicks";
    }
}
