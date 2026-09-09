using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListMembersListsRequestSortDir.ListMembersListsRequestSortDirSerializer))]
[Serializable]
public readonly record struct ListMembersListsRequestSortDir : IStringEnum
{
    public static readonly ListMembersListsRequestSortDir Asc = new(Values.Asc);

    public static readonly ListMembersListsRequestSortDir Desc = new(Values.Desc);

    public ListMembersListsRequestSortDir(string value)
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
    public static ListMembersListsRequestSortDir FromCustom(string value)
    {
        return new ListMembersListsRequestSortDir(value);
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

    public static bool operator ==(ListMembersListsRequestSortDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMembersListsRequestSortDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMembersListsRequestSortDir value) => value.Value;

    public static explicit operator ListMembersListsRequestSortDir(string value) => new(value);

    internal class ListMembersListsRequestSortDirSerializer
        : JsonConverter<ListMembersListsRequestSortDir>
    {
        public override ListMembersListsRequestSortDir Read(
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
            return new ListMembersListsRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMembersListsRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMembersListsRequestSortDir ReadAsPropertyName(
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
            return new ListMembersListsRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMembersListsRequestSortDir value,
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
