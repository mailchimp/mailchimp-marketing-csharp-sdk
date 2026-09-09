using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateStorePromoRuleEcommerceRequestStartsAtOne.UpdateStorePromoRuleEcommerceRequestStartsAtOneSerializer)
)]
[Serializable]
public readonly record struct UpdateStorePromoRuleEcommerceRequestStartsAtOne : IStringEnum
{
    public static readonly UpdateStorePromoRuleEcommerceRequestStartsAtOne Empty = new(
        Values.Empty
    );

    public static readonly UpdateStorePromoRuleEcommerceRequestStartsAtOne Zero0000 = new(
        Values.Zero0000
    );

    public static readonly UpdateStorePromoRuleEcommerceRequestStartsAtOne Zero0000000000 = new(
        Values.Zero0000000000
    );

    public UpdateStorePromoRuleEcommerceRequestStartsAtOne(string value)
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
    public static UpdateStorePromoRuleEcommerceRequestStartsAtOne FromCustom(string value)
    {
        return new UpdateStorePromoRuleEcommerceRequestStartsAtOne(value);
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
        UpdateStorePromoRuleEcommerceRequestStartsAtOne value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateStorePromoRuleEcommerceRequestStartsAtOne value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateStorePromoRuleEcommerceRequestStartsAtOne value) =>
        value.Value;

    public static explicit operator UpdateStorePromoRuleEcommerceRequestStartsAtOne(string value) =>
        new(value);

    internal class UpdateStorePromoRuleEcommerceRequestStartsAtOneSerializer
        : JsonConverter<UpdateStorePromoRuleEcommerceRequestStartsAtOne>
    {
        public override UpdateStorePromoRuleEcommerceRequestStartsAtOne Read(
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
            return new UpdateStorePromoRuleEcommerceRequestStartsAtOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateStorePromoRuleEcommerceRequestStartsAtOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateStorePromoRuleEcommerceRequestStartsAtOne ReadAsPropertyName(
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
            return new UpdateStorePromoRuleEcommerceRequestStartsAtOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateStorePromoRuleEcommerceRequestStartsAtOne value,
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
        public const string Empty = "";

        public const string Zero0000 = "0000-00-00";

        public const string Zero0000000000 = "0000-00-00 00:00:00";
    }
}
