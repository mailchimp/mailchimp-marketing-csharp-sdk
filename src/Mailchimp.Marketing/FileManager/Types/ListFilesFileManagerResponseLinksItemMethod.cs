using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListFilesFileManagerResponseLinksItemMethod.ListFilesFileManagerResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListFilesFileManagerResponseLinksItemMethod : IStringEnum
{
    public static readonly ListFilesFileManagerResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListFilesFileManagerResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListFilesFileManagerResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListFilesFileManagerResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListFilesFileManagerResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListFilesFileManagerResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListFilesFileManagerResponseLinksItemMethod Head = new(Values.Head);

    public ListFilesFileManagerResponseLinksItemMethod(string value)
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
    public static ListFilesFileManagerResponseLinksItemMethod FromCustom(string value)
    {
        return new ListFilesFileManagerResponseLinksItemMethod(value);
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
        ListFilesFileManagerResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListFilesFileManagerResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListFilesFileManagerResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListFilesFileManagerResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListFilesFileManagerResponseLinksItemMethodSerializer
        : JsonConverter<ListFilesFileManagerResponseLinksItemMethod>
    {
        public override ListFilesFileManagerResponseLinksItemMethod Read(
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
            return new ListFilesFileManagerResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFilesFileManagerResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFilesFileManagerResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListFilesFileManagerResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFilesFileManagerResponseLinksItemMethod value,
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
        public const string Get = "GET";

        public const string Post = "POST";

        public const string Put = "PUT";

        public const string Patch = "PATCH";

        public const string Delete = "DELETE";

        public const string Options = "OPTIONS";

        public const string Head = "HEAD";
    }
}
