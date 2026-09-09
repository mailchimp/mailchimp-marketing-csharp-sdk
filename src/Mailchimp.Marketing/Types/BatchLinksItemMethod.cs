using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(BatchLinksItemMethod.BatchLinksItemMethodSerializer))]
[Serializable]
public readonly record struct BatchLinksItemMethod : IStringEnum
{
    public static readonly BatchLinksItemMethod Get = new(Values.Get);

    public static readonly BatchLinksItemMethod Post = new(Values.Post);

    public static readonly BatchLinksItemMethod Put = new(Values.Put);

    public static readonly BatchLinksItemMethod Patch = new(Values.Patch);

    public static readonly BatchLinksItemMethod Delete = new(Values.Delete);

    public static readonly BatchLinksItemMethod Options = new(Values.Options);

    public static readonly BatchLinksItemMethod Head = new(Values.Head);

    public BatchLinksItemMethod(string value)
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
    public static BatchLinksItemMethod FromCustom(string value)
    {
        return new BatchLinksItemMethod(value);
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

    public static bool operator ==(BatchLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BatchLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BatchLinksItemMethod value) => value.Value;

    public static explicit operator BatchLinksItemMethod(string value) => new(value);

    internal class BatchLinksItemMethodSerializer : JsonConverter<BatchLinksItemMethod>
    {
        public override BatchLinksItemMethod Read(
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
            return new BatchLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BatchLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BatchLinksItemMethod ReadAsPropertyName(
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
            return new BatchLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BatchLinksItemMethod value,
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
