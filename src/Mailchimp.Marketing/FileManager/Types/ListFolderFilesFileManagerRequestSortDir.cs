using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFolderFilesFileManagerRequestSortDir.ListFolderFilesFileManagerRequestSortDirSerializer)
)]
[Serializable]
public readonly record struct ListFolderFilesFileManagerRequestSortDir : IStringEnum
{
    public static readonly ListFolderFilesFileManagerRequestSortDir Asc = new(Values.Asc);

    public static readonly ListFolderFilesFileManagerRequestSortDir Desc = new(Values.Desc);

    public ListFolderFilesFileManagerRequestSortDir(string value)
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
    public static ListFolderFilesFileManagerRequestSortDir FromCustom(string value)
    {
        return new ListFolderFilesFileManagerRequestSortDir(value);
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
        ListFolderFilesFileManagerRequestSortDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListFolderFilesFileManagerRequestSortDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListFolderFilesFileManagerRequestSortDir value) =>
        value.Value;

    public static explicit operator ListFolderFilesFileManagerRequestSortDir(string value) =>
        new(value);

    internal class ListFolderFilesFileManagerRequestSortDirSerializer
        : JsonConverter<ListFolderFilesFileManagerRequestSortDir>
    {
        public override ListFolderFilesFileManagerRequestSortDir Read(
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
            return new ListFolderFilesFileManagerRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFolderFilesFileManagerRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFolderFilesFileManagerRequestSortDir ReadAsPropertyName(
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
            return new ListFolderFilesFileManagerRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFolderFilesFileManagerRequestSortDir value,
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
