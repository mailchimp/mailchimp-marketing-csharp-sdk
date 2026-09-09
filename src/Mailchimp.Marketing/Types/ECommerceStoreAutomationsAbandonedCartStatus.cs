using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ECommerceStoreAutomationsAbandonedCartStatus.ECommerceStoreAutomationsAbandonedCartStatusSerializer)
)]
[Serializable]
public readonly record struct ECommerceStoreAutomationsAbandonedCartStatus : IStringEnum
{
    public static readonly ECommerceStoreAutomationsAbandonedCartStatus Save = new(Values.Save);

    public static readonly ECommerceStoreAutomationsAbandonedCartStatus Sending = new(
        Values.Sending
    );

    public static readonly ECommerceStoreAutomationsAbandonedCartStatus Paused = new(Values.Paused);

    public ECommerceStoreAutomationsAbandonedCartStatus(string value)
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
    public static ECommerceStoreAutomationsAbandonedCartStatus FromCustom(string value)
    {
        return new ECommerceStoreAutomationsAbandonedCartStatus(value);
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
        ECommerceStoreAutomationsAbandonedCartStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ECommerceStoreAutomationsAbandonedCartStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ECommerceStoreAutomationsAbandonedCartStatus value) =>
        value.Value;

    public static explicit operator ECommerceStoreAutomationsAbandonedCartStatus(string value) =>
        new(value);

    internal class ECommerceStoreAutomationsAbandonedCartStatusSerializer
        : JsonConverter<ECommerceStoreAutomationsAbandonedCartStatus>
    {
        public override ECommerceStoreAutomationsAbandonedCartStatus Read(
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
            return new ECommerceStoreAutomationsAbandonedCartStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ECommerceStoreAutomationsAbandonedCartStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ECommerceStoreAutomationsAbandonedCartStatus ReadAsPropertyName(
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
            return new ECommerceStoreAutomationsAbandonedCartStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ECommerceStoreAutomationsAbandonedCartStatus value,
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
        public const string Save = "save";

        public const string Sending = "sending";

        public const string Paused = "paused";
    }
}
