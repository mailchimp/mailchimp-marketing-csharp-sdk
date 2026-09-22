using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(PatchAudienceContactRequestSmsChannelMarketingConsentStatus.PatchAudienceContactRequestSmsChannelMarketingConsentStatusSerializer)
)]
[Serializable]
public readonly record struct PatchAudienceContactRequestSmsChannelMarketingConsentStatus
    : IStringEnum
{
    public static readonly PatchAudienceContactRequestSmsChannelMarketingConsentStatus Consented =
        new(Values.Consented);

    public static readonly PatchAudienceContactRequestSmsChannelMarketingConsentStatus Confirmed =
        new(Values.Confirmed);

    public static readonly PatchAudienceContactRequestSmsChannelMarketingConsentStatus Denied = new(
        Values.Denied
    );

    public static readonly PatchAudienceContactRequestSmsChannelMarketingConsentStatus Unknown =
        new(Values.Unknown);

    public PatchAudienceContactRequestSmsChannelMarketingConsentStatus(string value)
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
    public static PatchAudienceContactRequestSmsChannelMarketingConsentStatus FromCustom(
        string value
    )
    {
        return new PatchAudienceContactRequestSmsChannelMarketingConsentStatus(value);
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
        PatchAudienceContactRequestSmsChannelMarketingConsentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PatchAudienceContactRequestSmsChannelMarketingConsentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PatchAudienceContactRequestSmsChannelMarketingConsentStatus value
    ) => value.Value;

    public static explicit operator PatchAudienceContactRequestSmsChannelMarketingConsentStatus(
        string value
    ) => new(value);

    internal class PatchAudienceContactRequestSmsChannelMarketingConsentStatusSerializer
        : JsonConverter<PatchAudienceContactRequestSmsChannelMarketingConsentStatus>
    {
        public override PatchAudienceContactRequestSmsChannelMarketingConsentStatus Read(
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
            return new PatchAudienceContactRequestSmsChannelMarketingConsentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestSmsChannelMarketingConsentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatchAudienceContactRequestSmsChannelMarketingConsentStatus ReadAsPropertyName(
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
            return new PatchAudienceContactRequestSmsChannelMarketingConsentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestSmsChannelMarketingConsentStatus value,
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
