using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateStorePromoRuleEcommerceRequestTarget.UpdateStorePromoRuleEcommerceRequestTargetSerializer)
)]
[Serializable]
public readonly record struct UpdateStorePromoRuleEcommerceRequestTarget : IStringEnum
{
    public static readonly UpdateStorePromoRuleEcommerceRequestTarget PerItem = new(Values.PerItem);

    public static readonly UpdateStorePromoRuleEcommerceRequestTarget Total = new(Values.Total);

    public static readonly UpdateStorePromoRuleEcommerceRequestTarget Shipping = new(
        Values.Shipping
    );

    public UpdateStorePromoRuleEcommerceRequestTarget(string value)
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
    public static UpdateStorePromoRuleEcommerceRequestTarget FromCustom(string value)
    {
        return new UpdateStorePromoRuleEcommerceRequestTarget(value);
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
        UpdateStorePromoRuleEcommerceRequestTarget value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateStorePromoRuleEcommerceRequestTarget value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateStorePromoRuleEcommerceRequestTarget value) =>
        value.Value;

    public static explicit operator UpdateStorePromoRuleEcommerceRequestTarget(string value) =>
        new(value);

    internal class UpdateStorePromoRuleEcommerceRequestTargetSerializer
        : JsonConverter<UpdateStorePromoRuleEcommerceRequestTarget>
    {
        public override UpdateStorePromoRuleEcommerceRequestTarget Read(
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
            return new UpdateStorePromoRuleEcommerceRequestTarget(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateStorePromoRuleEcommerceRequestTarget value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateStorePromoRuleEcommerceRequestTarget ReadAsPropertyName(
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
            return new UpdateStorePromoRuleEcommerceRequestTarget(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateStorePromoRuleEcommerceRequestTarget value,
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
