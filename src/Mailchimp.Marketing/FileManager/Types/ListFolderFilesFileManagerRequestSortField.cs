using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFolderFilesFileManagerRequestSortField.ListFolderFilesFileManagerRequestSortFieldSerializer)
)]
[Serializable]
public readonly record struct ListFolderFilesFileManagerRequestSortField : IStringEnum
{
    public static readonly ListFolderFilesFileManagerRequestSortField AddedDate = new(
        Values.AddedDate
    );

    public static readonly ListFolderFilesFileManagerRequestSortField Name = new(Values.Name);

    public static readonly ListFolderFilesFileManagerRequestSortField Size = new(Values.Size);

    public ListFolderFilesFileManagerRequestSortField(string value)
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
    public static ListFolderFilesFileManagerRequestSortField FromCustom(string value)
    {
        return new ListFolderFilesFileManagerRequestSortField(value);
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
        ListFolderFilesFileManagerRequestSortField value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListFolderFilesFileManagerRequestSortField value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListFolderFilesFileManagerRequestSortField value) =>
        value.Value;

    public static explicit operator ListFolderFilesFileManagerRequestSortField(string value) =>
        new(value);

    internal class ListFolderFilesFileManagerRequestSortFieldSerializer
        : JsonConverter<ListFolderFilesFileManagerRequestSortField>
    {
        public override ListFolderFilesFileManagerRequestSortField Read(
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
            return new ListFolderFilesFileManagerRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFolderFilesFileManagerRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFolderFilesFileManagerRequestSortField ReadAsPropertyName(
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
            return new ListFolderFilesFileManagerRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFolderFilesFileManagerRequestSortField value,
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
        public const string AddedDate = "added_date";

        public const string Name = "name";

        public const string Size = "size";
    }
}
