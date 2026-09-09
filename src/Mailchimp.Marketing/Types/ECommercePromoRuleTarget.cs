using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ECommercePromoRuleTarget.ECommercePromoRuleTargetSerializer))]
[Serializable]
public readonly record struct ECommercePromoRuleTarget : IStringEnum
{
    public static readonly ECommercePromoRuleTarget PerItem = new(Values.PerItem);

    public static readonly ECommercePromoRuleTarget Total = new(Values.Total);

    public static readonly ECommercePromoRuleTarget Shipping = new(Values.Shipping);

    public ECommercePromoRuleTarget(string value)
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
    public static ECommercePromoRuleTarget FromCustom(string value)
    {
        return new ECommercePromoRuleTarget(value);
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

    public static bool operator ==(ECommercePromoRuleTarget value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ECommercePromoRuleTarget value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ECommercePromoRuleTarget value) => value.Value;

    public static explicit operator ECommercePromoRuleTarget(string value) => new(value);

    internal class ECommercePromoRuleTargetSerializer : JsonConverter<ECommercePromoRuleTarget>
    {
        public override ECommercePromoRuleTarget Read(
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
            return new ECommercePromoRuleTarget(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommercePromoRuleTarget value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommercePromoRuleTarget ReadAsPropertyName(
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
            return new ECommercePromoRuleTarget(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommercePromoRuleTarget value,
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
        public const string PerItem = "per_item";

        public const string Total = "total";

        public const string Shipping = "shipping";
    }
}
