using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(GalleryFileLinksItemMethod.GalleryFileLinksItemMethodSerializer))]
[Serializable]
public readonly record struct GalleryFileLinksItemMethod : IStringEnum
{
    public static readonly GalleryFileLinksItemMethod Get = new(Values.Get);

    public static readonly GalleryFileLinksItemMethod Post = new(Values.Post);

    public static readonly GalleryFileLinksItemMethod Put = new(Values.Put);

    public static readonly GalleryFileLinksItemMethod Patch = new(Values.Patch);

    public static readonly GalleryFileLinksItemMethod Delete = new(Values.Delete);

    public static readonly GalleryFileLinksItemMethod Options = new(Values.Options);

    public static readonly GalleryFileLinksItemMethod Head = new(Values.Head);

    public GalleryFileLinksItemMethod(string value)
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
    public static GalleryFileLinksItemMethod FromCustom(string value)
    {
        return new GalleryFileLinksItemMethod(value);
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

    public static bool operator ==(GalleryFileLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GalleryFileLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GalleryFileLinksItemMethod value) => value.Value;

    public static explicit operator GalleryFileLinksItemMethod(string value) => new(value);

    internal class GalleryFileLinksItemMethodSerializer : JsonConverter<GalleryFileLinksItemMethod>
    {
        public override GalleryFileLinksItemMethod Read(
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
            return new GalleryFileLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GalleryFileLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GalleryFileLinksItemMethod ReadAsPropertyName(
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
            return new GalleryFileLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GalleryFileLinksItemMethod value,
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
