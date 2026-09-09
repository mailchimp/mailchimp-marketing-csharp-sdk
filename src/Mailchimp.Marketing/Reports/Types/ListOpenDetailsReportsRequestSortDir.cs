using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListOpenDetailsReportsRequestSortDir.ListOpenDetailsReportsRequestSortDirSerializer)
)]
[Serializable]
public readonly record struct ListOpenDetailsReportsRequestSortDir : IStringEnum
{
    public static readonly ListOpenDetailsReportsRequestSortDir Asc = new(Values.Asc);

    public static readonly ListOpenDetailsReportsRequestSortDir Desc = new(Values.Desc);

    public ListOpenDetailsReportsRequestSortDir(string value)
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
    public static ListOpenDetailsReportsRequestSortDir FromCustom(string value)
    {
        return new ListOpenDetailsReportsRequestSortDir(value);
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

    public static bool operator ==(ListOpenDetailsReportsRequestSortDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListOpenDetailsReportsRequestSortDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListOpenDetailsReportsRequestSortDir value) =>
        value.Value;

    public static explicit operator ListOpenDetailsReportsRequestSortDir(string value) =>
        new(value);

    internal class ListOpenDetailsReportsRequestSortDirSerializer
        : JsonConverter<ListOpenDetailsReportsRequestSortDir>
    {
        public override ListOpenDetailsReportsRequestSortDir Read(
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
            return new ListOpenDetailsReportsRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListOpenDetailsReportsRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListOpenDetailsReportsRequestSortDir ReadAsPropertyName(
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
            return new ListOpenDetailsReportsRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListOpenDetailsReportsRequestSortDir value,
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
