using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ECommercePromoRuleLinksItemMethod.ECommercePromoRuleLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ECommercePromoRuleLinksItemMethod : IStringEnum
{
    public static readonly ECommercePromoRuleLinksItemMethod Get = new(Values.Get);

    public static readonly ECommercePromoRuleLinksItemMethod Post = new(Values.Post);

    public static readonly ECommercePromoRuleLinksItemMethod Put = new(Values.Put);

    public static readonly ECommercePromoRuleLinksItemMethod Patch = new(Values.Patch);

    public static readonly ECommercePromoRuleLinksItemMethod Delete = new(Values.Delete);

    public static readonly ECommercePromoRuleLinksItemMethod Options = new(Values.Options);

    public static readonly ECommercePromoRuleLinksItemMethod Head = new(Values.Head);

    public ECommercePromoRuleLinksItemMethod(string value)
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
    public static ECommercePromoRuleLinksItemMethod FromCustom(string value)
    {
        return new ECommercePromoRuleLinksItemMethod(value);
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

    public static bool operator ==(ECommercePromoRuleLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ECommercePromoRuleLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ECommercePromoRuleLinksItemMethod value) => value.Value;

    public static explicit operator ECommercePromoRuleLinksItemMethod(string value) => new(value);

    internal class ECommercePromoRuleLinksItemMethodSerializer
        : JsonConverter<ECommercePromoRuleLinksItemMethod>
    {
        public override ECommercePromoRuleLinksItemMethod Read(
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
            return new ECommercePromoRuleLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommercePromoRuleLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommercePromoRuleLinksItemMethod ReadAsPropertyName(
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
            return new ECommercePromoRuleLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommercePromoRuleLinksItemMethod value,
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
