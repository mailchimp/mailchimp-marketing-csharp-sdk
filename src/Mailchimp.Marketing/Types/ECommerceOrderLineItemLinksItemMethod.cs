using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ECommerceOrderLineItemLinksItemMethod.ECommerceOrderLineItemLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ECommerceOrderLineItemLinksItemMethod : IStringEnum
{
    public static readonly ECommerceOrderLineItemLinksItemMethod Get = new(Values.Get);

    public static readonly ECommerceOrderLineItemLinksItemMethod Post = new(Values.Post);

    public static readonly ECommerceOrderLineItemLinksItemMethod Put = new(Values.Put);

    public static readonly ECommerceOrderLineItemLinksItemMethod Patch = new(Values.Patch);

    public static readonly ECommerceOrderLineItemLinksItemMethod Delete = new(Values.Delete);

    public static readonly ECommerceOrderLineItemLinksItemMethod Options = new(Values.Options);

    public static readonly ECommerceOrderLineItemLinksItemMethod Head = new(Values.Head);

    public ECommerceOrderLineItemLinksItemMethod(string value)
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
    public static ECommerceOrderLineItemLinksItemMethod FromCustom(string value)
    {
        return new ECommerceOrderLineItemLinksItemMethod(value);
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

    public static bool operator ==(ECommerceOrderLineItemLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ECommerceOrderLineItemLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ECommerceOrderLineItemLinksItemMethod value) =>
        value.Value;

    public static explicit operator ECommerceOrderLineItemLinksItemMethod(string value) =>
        new(value);

    internal class ECommerceOrderLineItemLinksItemMethodSerializer
        : JsonConverter<ECommerceOrderLineItemLinksItemMethod>
    {
        public override ECommerceOrderLineItemLinksItemMethod Read(
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
            return new ECommerceOrderLineItemLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommerceOrderLineItemLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommerceOrderLineItemLinksItemMethod ReadAsPropertyName(
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
            return new ECommerceOrderLineItemLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommerceOrderLineItemLinksItemMethod value,
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
