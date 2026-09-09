using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMemberNotesListsRequestSortField.ListMemberNotesListsRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListMemberNotesListsRequestSortField : IStringEnum
{
    public static readonly ListMemberNotesListsRequestSortField CreatedAt = new(Values.CreatedAt);

    public static readonly ListMemberNotesListsRequestSortField UpdatedAt = new(Values.UpdatedAt);

    public static readonly ListMemberNotesListsRequestSortField NoteId = new(Values.NoteId);

    public ListMemberNotesListsRequestSortField(string value)
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
    public static ListMemberNotesListsRequestSortField FromCustom(string value)
    {
        return new ListMemberNotesListsRequestSortField(value);
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

    public static bool operator ==(ListMemberNotesListsRequestSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMemberNotesListsRequestSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMemberNotesListsRequestSortField value) =>
        value.Value;

    public static explicit operator ListMemberNotesListsRequestSortField(string value) =>
        new(value);

    internal class ListMemberNotesListsRequestSortFieldSerializer
        : JsonConverter<ListMemberNotesListsRequestSortField>
    {
        public override ListMemberNotesListsRequestSortField Read(
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
            return new ListMemberNotesListsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMemberNotesListsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMemberNotesListsRequestSortField ReadAsPropertyName(
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
            return new ListMemberNotesListsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMemberNotesListsRequestSortField value,
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

        public const string NoteId = "note_id";
    }
}
