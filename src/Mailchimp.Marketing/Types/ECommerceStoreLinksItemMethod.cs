using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ECommerceStoreLinksItemMethod.ECommerceStoreLinksItemMethodSerializer))]
[Serializable]
public readonly record struct ECommerceStoreLinksItemMethod : IStringEnum
{
    public static readonly ECommerceStoreLinksItemMethod Get = new(Values.Get);

    public static readonly ECommerceStoreLinksItemMethod Post = new(Values.Post);

    public static readonly ECommerceStoreLinksItemMethod Put = new(Values.Put);

    public static readonly ECommerceStoreLinksItemMethod Patch = new(Values.Patch);

    public static readonly ECommerceStoreLinksItemMethod Delete = new(Values.Delete);

    public static readonly ECommerceStoreLinksItemMethod Options = new(Values.Options);

    public static readonly ECommerceStoreLinksItemMethod Head = new(Values.Head);

    public ECommerceStoreLinksItemMethod(string value)
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
    public static ECommerceStoreLinksItemMethod FromCustom(string value)
    {
        return new ECommerceStoreLinksItemMethod(value);
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

    public static bool operator ==(ECommerceStoreLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ECommerceStoreLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ECommerceStoreLinksItemMethod value) => value.Value;

    public static explicit operator ECommerceStoreLinksItemMethod(string value) => new(value);

    internal class ECommerceStoreLinksItemMethodSerializer
        : JsonConverter<ECommerceStoreLinksItemMethod>
    {
        public override ECommerceStoreLinksItemMethod Read(
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
            return new ECommerceStoreLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommerceStoreLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommerceStoreLinksItemMethod ReadAsPropertyName(
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
            return new ECommerceStoreLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommerceStoreLinksItemMethod value,
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
