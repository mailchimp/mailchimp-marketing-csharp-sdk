using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AudiencesContactEmailChannelMarketingConsentStatus.AudiencesContactEmailChannelMarketingConsentStatusSerializer)
)]
[Serializable]
public readonly record struct AudiencesContactEmailChannelMarketingConsentStatus : IStringEnum
{
    public static readonly AudiencesContactEmailChannelMarketingConsentStatus Consented = new(
        Values.Consented
    );

    public static readonly AudiencesContactEmailChannelMarketingConsentStatus Denied = new(
        Values.Denied
    );

    public static readonly AudiencesContactEmailChannelMarketingConsentStatus Confirmed = new(
        Values.Confirmed
    );

    public static readonly AudiencesContactEmailChannelMarketingConsentStatus Unknown = new(
        Values.Unknown
    );

    public AudiencesContactEmailChannelMarketingConsentStatus(string value)
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
    public static AudiencesContactEmailChannelMarketingConsentStatus FromCustom(string value)
    {
        return new AudiencesContactEmailChannelMarketingConsentStatus(value);
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
        AudiencesContactEmailChannelMarketingConsentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AudiencesContactEmailChannelMarketingConsentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AudiencesContactEmailChannelMarketingConsentStatus value
    ) => value.Value;

    public static explicit operator AudiencesContactEmailChannelMarketingConsentStatus(
        string value
    ) => new(value);

    internal class AudiencesContactEmailChannelMarketingConsentStatusSerializer
        : JsonConverter<AudiencesContactEmailChannelMarketingConsentStatus>
    {
        public override AudiencesContactEmailChannelMarketingConsentStatus Read(
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
            return new AudiencesContactEmailChannelMarketingConsentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AudiencesContactEmailChannelMarketingConsentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AudiencesContactEmailChannelMarketingConsentStatus ReadAsPropertyName(
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
            return new AudiencesContactEmailChannelMarketingConsentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AudiencesContactEmailChannelMarketingConsentStatus value,
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

        public const string Denied = "denied";

        public const string Confirmed = "confirmed";

        public const string Unknown = "unknown";
    }
}
