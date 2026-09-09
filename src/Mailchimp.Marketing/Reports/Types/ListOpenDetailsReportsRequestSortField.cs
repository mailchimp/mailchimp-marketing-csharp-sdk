using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListOpenDetailsReportsRequestSortField.ListOpenDetailsReportsRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListOpenDetailsReportsRequestSortField : IStringEnum
{
    public static readonly ListOpenDetailsReportsRequestSortField OpensCount = new(
        Values.OpensCount
    );

    public ListOpenDetailsReportsRequestSortField(string value)
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
    public static ListOpenDetailsReportsRequestSortField FromCustom(string value)
    {
        return new ListOpenDetailsReportsRequestSortField(value);
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

    public static bool operator ==(ListOpenDetailsReportsRequestSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListOpenDetailsReportsRequestSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListOpenDetailsReportsRequestSortField value) =>
        value.Value;

    public static explicit operator ListOpenDetailsReportsRequestSortField(string value) =>
        new(value);

    internal class ListOpenDetailsReportsRequestSortFieldSerializer
        : JsonConverter<ListOpenDetailsReportsRequestSortField>
    {
        public override ListOpenDetailsReportsRequestSortField Read(
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
            return new ListOpenDetailsReportsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListOpenDetailsReportsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListOpenDetailsReportsRequestSortField ReadAsPropertyName(
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
            return new ListOpenDetailsReportsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListOpenDetailsReportsRequestSortField value,
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
        public const string OpensCount = "opens_count";
    }
}
