using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMemberNotesListsRequestSortDir.ListMemberNotesListsRequestSortDirSerializer)
)]
[Serializable]
public readonly record struct ListMemberNotesListsRequestSortDir : IStringEnum
{
    public static readonly ListMemberNotesListsRequestSortDir Asc = new(Values.Asc);

    public static readonly ListMemberNotesListsRequestSortDir Desc = new(Values.Desc);

    public ListMemberNotesListsRequestSortDir(string value)
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
    public static ListMemberNotesListsRequestSortDir FromCustom(string value)
    {
        return new ListMemberNotesListsRequestSortDir(value);
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

    public static bool operator ==(ListMemberNotesListsRequestSortDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMemberNotesListsRequestSortDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMemberNotesListsRequestSortDir value) => value.Value;

    public static explicit operator ListMemberNotesListsRequestSortDir(string value) => new(value);

    internal class ListMemberNotesListsRequestSortDirSerializer
        : JsonConverter<ListMemberNotesListsRequestSortDir>
    {
        public override ListMemberNotesListsRequestSortDir Read(
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
            return new ListMemberNotesListsRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMemberNotesListsRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMemberNotesListsRequestSortDir ReadAsPropertyName(
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
            return new ListMemberNotesListsRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMemberNotesListsRequestSortDir value,
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
