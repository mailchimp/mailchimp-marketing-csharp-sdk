using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFilesFileManagerRequestSortDir.ListFilesFileManagerRequestSortDirSerializer)
)]
[Serializable]
public readonly record struct ListFilesFileManagerRequestSortDir : IStringEnum
{
    public static readonly ListFilesFileManagerRequestSortDir Asc = new(Values.Asc);

    public static readonly ListFilesFileManagerRequestSortDir Desc = new(Values.Desc);

    public ListFilesFileManagerRequestSortDir(string value)
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
    public static ListFilesFileManagerRequestSortDir FromCustom(string value)
    {
        return new ListFilesFileManagerRequestSortDir(value);
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

    public static bool operator ==(ListFilesFileManagerRequestSortDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListFilesFileManagerRequestSortDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListFilesFileManagerRequestSortDir value) => value.Value;

    public static explicit operator ListFilesFileManagerRequestSortDir(string value) => new(value);

    internal class ListFilesFileManagerRequestSortDirSerializer
        : JsonConverter<ListFilesFileManagerRequestSortDir>
    {
        public override ListFilesFileManagerRequestSortDir Read(
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
            return new ListFilesFileManagerRequestSortDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFilesFileManagerRequestSortDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFilesFileManagerRequestSortDir ReadAsPropertyName(
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
            return new ListFilesFileManagerRequestSortDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFilesFileManagerRequestSortDir value,
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
