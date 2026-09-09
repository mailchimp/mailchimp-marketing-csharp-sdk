using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignsDeliveryStatusStatus.CampaignsDeliveryStatusStatusSerializer))]
[Serializable]
public readonly record struct CampaignsDeliveryStatusStatus : IStringEnum
{
    public static readonly CampaignsDeliveryStatusStatus Delivering = new(Values.Delivering);

    public static readonly CampaignsDeliveryStatusStatus Delivered = new(Values.Delivered);

    public static readonly CampaignsDeliveryStatusStatus Canceling = new(Values.Canceling);

    public static readonly CampaignsDeliveryStatusStatus Canceled = new(Values.Canceled);

    public CampaignsDeliveryStatusStatus(string value)
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
    public static CampaignsDeliveryStatusStatus FromCustom(string value)
    {
        return new CampaignsDeliveryStatusStatus(value);
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

    public static bool operator ==(CampaignsDeliveryStatusStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignsDeliveryStatusStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignsDeliveryStatusStatus value) => value.Value;

    public static explicit operator CampaignsDeliveryStatusStatus(string value) => new(value);

    internal class CampaignsDeliveryStatusStatusSerializer
        : JsonConverter<CampaignsDeliveryStatusStatus>
    {
        public override CampaignsDeliveryStatusStatus Read(
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
            return new CampaignsDeliveryStatusStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsDeliveryStatusStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsDeliveryStatusStatus ReadAsPropertyName(
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
            return new CampaignsDeliveryStatusStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsDeliveryStatusStatus value,
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
