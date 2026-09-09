using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ECommerceCartLinksItemMethod.ECommerceCartLinksItemMethodSerializer))]
[Serializable]
public readonly record struct ECommerceCartLinksItemMethod : IStringEnum
{
    public static readonly ECommerceCartLinksItemMethod Get = new(Values.Get);

    public static readonly ECommerceCartLinksItemMethod Post = new(Values.Post);

    public static readonly ECommerceCartLinksItemMethod Put = new(Values.Put);

    public static readonly ECommerceCartLinksItemMethod Patch = new(Values.Patch);

    public static readonly ECommerceCartLinksItemMethod Delete = new(Values.Delete);

    public static readonly ECommerceCartLinksItemMethod Options = new(Values.Options);

    public static readonly ECommerceCartLinksItemMethod Head = new(Values.Head);

    public ECommerceCartLinksItemMethod(string value)
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
    public static ECommerceCartLinksItemMethod FromCustom(string value)
    {
        return new ECommerceCartLinksItemMethod(value);
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

    public static bool operator ==(ECommerceCartLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ECommerceCartLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ECommerceCartLinksItemMethod value) => value.Value;

    public static explicit operator ECommerceCartLinksItemMethod(string value) => new(value);

    internal class ECommerceCartLinksItemMethodSerializer
        : JsonConverter<ECommerceCartLinksItemMethod>
    {
        public override ECommerceCartLinksItemMethod Read(
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
            return new ECommerceCartLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommerceCartLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommerceCartLinksItemMethod ReadAsPropertyName(
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
            return new ECommerceCartLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommerceCartLinksItemMethod value,
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
