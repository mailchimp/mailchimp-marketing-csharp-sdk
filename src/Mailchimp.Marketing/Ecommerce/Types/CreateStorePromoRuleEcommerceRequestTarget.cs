using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateStorePromoRuleEcommerceRequestTarget.CreateStorePromoRuleEcommerceRequestTargetSerializer)
)]
[Serializable]
public readonly record struct CreateStorePromoRuleEcommerceRequestTarget : IStringEnum
{
    public static readonly CreateStorePromoRuleEcommerceRequestTarget PerItem = new(Values.PerItem);

    public static readonly CreateStorePromoRuleEcommerceRequestTarget Total = new(Values.Total);

    public static readonly CreateStorePromoRuleEcommerceRequestTarget Shipping = new(
        Values.Shipping
    );

    public CreateStorePromoRuleEcommerceRequestTarget(string value)
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
    public static CreateStorePromoRuleEcommerceRequestTarget FromCustom(string value)
    {
        return new CreateStorePromoRuleEcommerceRequestTarget(value);
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
        CreateStorePromoRuleEcommerceRequestTarget value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateStorePromoRuleEcommerceRequestTarget value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateStorePromoRuleEcommerceRequestTarget value) =>
        value.Value;

    public static explicit operator CreateStorePromoRuleEcommerceRequestTarget(string value) =>
        new(value);

    internal class CreateStorePromoRuleEcommerceRequestTargetSerializer
        : JsonConverter<CreateStorePromoRuleEcommerceRequestTarget>
    {
        public override CreateStorePromoRuleEcommerceRequestTarget Read(
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
            return new CreateStorePromoRuleEcommerceRequestTarget(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateStorePromoRuleEcommerceRequestTarget value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateStorePromoRuleEcommerceRequestTarget ReadAsPropertyName(
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
            return new CreateStorePromoRuleEcommerceRequestTarget(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateStorePromoRuleEcommerceRequestTarget value,
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
