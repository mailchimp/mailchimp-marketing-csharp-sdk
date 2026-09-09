using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateStorePromoRuleEcommerceRequestType.CreateStorePromoRuleEcommerceRequestTypeSerializer)
)]
[Serializable]
public readonly record struct CreateStorePromoRuleEcommerceRequestType : IStringEnum
{
    public static readonly CreateStorePromoRuleEcommerceRequestType Fixed = new(Values.Fixed);

    public static readonly CreateStorePromoRuleEcommerceRequestType Percentage = new(
        Values.Percentage
    );

    public CreateStorePromoRuleEcommerceRequestType(string value)
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
    public static CreateStorePromoRuleEcommerceRequestType FromCustom(string value)
    {
        return new CreateStorePromoRuleEcommerceRequestType(value);
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
        CreateStorePromoRuleEcommerceRequestType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateStorePromoRuleEcommerceRequestType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateStorePromoRuleEcommerceRequestType value) =>
        value.Value;

    public static explicit operator CreateStorePromoRuleEcommerceRequestType(string value) =>
        new(value);

    internal class CreateStorePromoRuleEcommerceRequestTypeSerializer
        : JsonConverter<CreateStorePromoRuleEcommerceRequestType>
    {
        public override CreateStorePromoRuleEcommerceRequestType Read(
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
            return new CreateStorePromoRuleEcommerceRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateStorePromoRuleEcommerceRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateStorePromoRuleEcommerceRequestType ReadAsPropertyName(
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
            return new CreateStorePromoRuleEcommerceRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateStorePromoRuleEcommerceRequestType value,
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
        public const string Fixed = "fixed";

        public const string Percentage = "percentage";
    }
}
