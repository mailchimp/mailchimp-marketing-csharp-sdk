using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ECommerceOrderLinksItemMethod.ECommerceOrderLinksItemMethodSerializer))]
[Serializable]
public readonly record struct ECommerceOrderLinksItemMethod : IStringEnum
{
    public static readonly ECommerceOrderLinksItemMethod Get = new(Values.Get);

    public static readonly ECommerceOrderLinksItemMethod Post = new(Values.Post);

    public static readonly ECommerceOrderLinksItemMethod Put = new(Values.Put);

    public static readonly ECommerceOrderLinksItemMethod Patch = new(Values.Patch);

    public static readonly ECommerceOrderLinksItemMethod Delete = new(Values.Delete);

    public static readonly ECommerceOrderLinksItemMethod Options = new(Values.Options);

    public static readonly ECommerceOrderLinksItemMethod Head = new(Values.Head);

    public ECommerceOrderLinksItemMethod(string value)
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
    public static ECommerceOrderLinksItemMethod FromCustom(string value)
    {
        return new ECommerceOrderLinksItemMethod(value);
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

    public static bool operator ==(ECommerceOrderLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ECommerceOrderLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ECommerceOrderLinksItemMethod value) => value.Value;

    public static explicit operator ECommerceOrderLinksItemMethod(string value) => new(value);

    internal class ECommerceOrderLinksItemMethodSerializer
        : JsonConverter<ECommerceOrderLinksItemMethod>
    {
        public override ECommerceOrderLinksItemMethod Read(
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
            return new ECommerceOrderLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommerceOrderLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommerceOrderLinksItemMethod ReadAsPropertyName(
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
            return new ECommerceOrderLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommerceOrderLinksItemMethod value,
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
