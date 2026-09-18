using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AudiencesContactSmsChannelMarketingConsentStatus.AudiencesContactSmsChannelMarketingConsentStatusSerializer)
)]
[Serializable]
public readonly record struct AudiencesContactSmsChannelMarketingConsentStatus : IStringEnum
{
    public static readonly AudiencesContactSmsChannelMarketingConsentStatus Consented = new(
        Values.Consented
    );

    public static readonly AudiencesContactSmsChannelMarketingConsentStatus Confirmed = new(
        Values.Confirmed
    );

    public static readonly AudiencesContactSmsChannelMarketingConsentStatus Denied = new(
        Values.Denied
    );

    public static readonly AudiencesContactSmsChannelMarketingConsentStatus Unknown = new(
        Values.Unknown
    );

    public AudiencesContactSmsChannelMarketingConsentStatus(string value)
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
    public static AudiencesContactSmsChannelMarketingConsentStatus FromCustom(string value)
    {
        return new AudiencesContactSmsChannelMarketingConsentStatus(value);
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
        AudiencesContactSmsChannelMarketingConsentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AudiencesContactSmsChannelMarketingConsentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AudiencesContactSmsChannelMarketingConsentStatus value
    ) => value.Value;

    public static explicit operator AudiencesContactSmsChannelMarketingConsentStatus(
        string value
    ) => new(value);

    internal class AudiencesContactSmsChannelMarketingConsentStatusSerializer
        : JsonConverter<AudiencesContactSmsChannelMarketingConsentStatus>
    {
        public override AudiencesContactSmsChannelMarketingConsentStatus Read(
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
            return new AudiencesContactSmsChannelMarketingConsentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AudiencesContactSmsChannelMarketingConsentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AudiencesContactSmsChannelMarketingConsentStatus ReadAsPropertyName(
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
            return new AudiencesContactSmsChannelMarketingConsentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AudiencesContactSmsChannelMarketingConsentStatus value,
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
        public const string Consented = "consented";

        public const string Confirmed = "confirmed";

        public const string Denied = "denied";

        public const string Unknown = "unknown";
    }
}
