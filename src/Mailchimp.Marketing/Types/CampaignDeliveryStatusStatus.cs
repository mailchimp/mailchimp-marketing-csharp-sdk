using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignDeliveryStatusStatus.CampaignDeliveryStatusStatusSerializer))]
[Serializable]
public readonly record struct CampaignDeliveryStatusStatus : IStringEnum
{
    public static readonly CampaignDeliveryStatusStatus Delivering = new(Values.Delivering);

    public static readonly CampaignDeliveryStatusStatus Delivered = new(Values.Delivered);

    public static readonly CampaignDeliveryStatusStatus Canceling = new(Values.Canceling);

    public static readonly CampaignDeliveryStatusStatus Canceled = new(Values.Canceled);

    public CampaignDeliveryStatusStatus(string value)
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
    public static CampaignDeliveryStatusStatus FromCustom(string value)
    {
        return new CampaignDeliveryStatusStatus(value);
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

    public static bool operator ==(CampaignDeliveryStatusStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignDeliveryStatusStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignDeliveryStatusStatus value) => value.Value;

    public static explicit operator CampaignDeliveryStatusStatus(string value) => new(value);

    internal class CampaignDeliveryStatusStatusSerializer
        : JsonConverter<CampaignDeliveryStatusStatus>
    {
        public override CampaignDeliveryStatusStatus Read(
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
            return new CampaignDeliveryStatusStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignDeliveryStatusStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignDeliveryStatusStatus ReadAsPropertyName(
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
            return new CampaignDeliveryStatusStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignDeliveryStatusStatus value,
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
        public const string Delivering = "delivering";

        public const string Delivered = "delivered";

        public const string Canceling = "canceling";

        public const string Canceled = "canceled";
    }
}
