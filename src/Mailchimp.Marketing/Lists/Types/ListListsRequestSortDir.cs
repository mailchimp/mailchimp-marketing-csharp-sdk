using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListListsRequestSortDir.ListListsRequestSortDirSerializer))]
[Serializable]
public readonly record struct ListListsRequestSortDir : IStringEnum
{
    public static readonly ListListsRequestSortDir Asc = new(Values.Asc);

    public static readonly ListListsRequestSortDir Desc = new(Values.Desc);

    public ListListsRequestSortDir(string value)
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
    public static ListListsRequestSortDir FromCustom(string value)
    {
        return new ListListsRequestSortDir(value);
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

    public static bool operator ==(ListListsRequestSortDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListListsRequestSortDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListListsRequestSortDir value) => value.Value;

    public static explicit operator ListListsRequestSortDir(string value) => new(value);

    internal class ListListsRequestSortDirSerializer : JsonConverter<ListListsRequestSortDir>
    {
        public override ListListsRequestSortDir Read(
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
            return new ListListsRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListListsRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListListsRequestSortDir ReadAsPropertyName(
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
            return new ListListsRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListListsRequestSortDir value,
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
