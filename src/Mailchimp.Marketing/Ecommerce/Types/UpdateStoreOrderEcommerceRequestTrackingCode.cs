using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateStoreOrderEcommerceRequestTrackingCode.UpdateStoreOrderEcommerceRequestTrackingCodeSerializer)
)]
[Serializable]
public readonly record struct UpdateStoreOrderEcommerceRequestTrackingCode : IStringEnum
{
    public static readonly UpdateStoreOrderEcommerceRequestTrackingCode Prec = new(Values.Prec);

    public UpdateStoreOrderEcommerceRequestTrackingCode(string value)
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
    public static UpdateStoreOrderEcommerceRequestTrackingCode FromCustom(string value)
    {
        return new UpdateStoreOrderEcommerceRequestTrackingCode(value);
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
        UpdateStoreOrderEcommerceRequestTrackingCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateStoreOrderEcommerceRequestTrackingCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateStoreOrderEcommerceRequestTrackingCode value) =>
        value.Value;

    public static explicit operator UpdateStoreOrderEcommerceRequestTrackingCode(string value) =>
        new(value);

    internal class UpdateStoreOrderEcommerceRequestTrackingCodeSerializer
        : JsonConverter<UpdateStoreOrderEcommerceRequestTrackingCode>
    {
        public override UpdateStoreOrderEcommerceRequestTrackingCode Read(
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
            return new UpdateStoreOrderEcommerceRequestTrackingCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateStoreOrderEcommerceRequestTrackingCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateStoreOrderEcommerceRequestTrackingCode ReadAsPropertyName(
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
            return new UpdateStoreOrderEcommerceRequestTrackingCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateStoreOrderEcommerceRequestTrackingCode value,
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
        public const string Prec = "prec";
    }
}
