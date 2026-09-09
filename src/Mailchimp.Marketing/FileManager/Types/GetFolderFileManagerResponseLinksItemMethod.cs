using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(GetFolderFileManagerResponseLinksItemMethod.GetFolderFileManagerResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct GetFolderFileManagerResponseLinksItemMethod : IStringEnum
{
    public static readonly GetFolderFileManagerResponseLinksItemMethod Get = new(Values.Get);

    public static readonly GetFolderFileManagerResponseLinksItemMethod Post = new(Values.Post);

    public static readonly GetFolderFileManagerResponseLinksItemMethod Put = new(Values.Put);

    public static readonly GetFolderFileManagerResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly GetFolderFileManagerResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly GetFolderFileManagerResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly GetFolderFileManagerResponseLinksItemMethod Head = new(Values.Head);

    public GetFolderFileManagerResponseLinksItemMethod(string value)
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
    public static GetFolderFileManagerResponseLinksItemMethod FromCustom(string value)
    {
        return new GetFolderFileManagerResponseLinksItemMethod(value);
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
        GetFolderFileManagerResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetFolderFileManagerResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetFolderFileManagerResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator GetFolderFileManagerResponseLinksItemMethod(string value) =>
        new(value);

    internal class GetFolderFileManagerResponseLinksItemMethodSerializer
        : JsonConverter<GetFolderFileManagerResponseLinksItemMethod>
    {
        public override GetFolderFileManagerResponseLinksItemMethod Read(
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
            return new GetFolderFileManagerResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetFolderFileManagerResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetFolderFileManagerResponseLinksItemMethod ReadAsPropertyName(
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
            return new GetFolderFileManagerResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetFolderFileManagerResponseLinksItemMethod value,
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
