using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateStoreOrderEcommerceRequestPromosItemType.UpdateStoreOrderEcommerceRequestPromosItemTypeSerializer)
)]
[Serializable]
public readonly record struct UpdateStoreOrderEcommerceRequestPromosItemType : IStringEnum
{
    public static readonly UpdateStoreOrderEcommerceRequestPromosItemType Fixed = new(Values.Fixed);

    public static readonly UpdateStoreOrderEcommerceRequestPromosItemType Percentage = new(
        Values.Percentage
    );

    public UpdateStoreOrderEcommerceRequestPromosItemType(string value)
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
    public static UpdateStoreOrderEcommerceRequestPromosItemType FromCustom(string value)
    {
        return new UpdateStoreOrderEcommerceRequestPromosItemType(value);
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
        UpdateStoreOrderEcommerceRequestPromosItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateStoreOrderEcommerceRequestPromosItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateStoreOrderEcommerceRequestPromosItemType value) =>
        value.Value;

    public static explicit operator UpdateStoreOrderEcommerceRequestPromosItemType(string value) =>
        new(value);

    internal class UpdateStoreOrderEcommerceRequestPromosItemTypeSerializer
        : JsonConverter<UpdateStoreOrderEcommerceRequestPromosItemType>
    {
        public override UpdateStoreOrderEcommerceRequestPromosItemType Read(
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
            return new UpdateStoreOrderEcommerceRequestPromosItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateStoreOrderEcommerceRequestPromosItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateStoreOrderEcommerceRequestPromosItemType ReadAsPropertyName(
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
            return new UpdateStoreOrderEcommerceRequestPromosItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateStoreOrderEcommerceRequestPromosItemType value,
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
