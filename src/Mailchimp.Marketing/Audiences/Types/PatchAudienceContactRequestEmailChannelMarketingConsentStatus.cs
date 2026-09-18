using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(PatchAudienceContactRequestEmailChannelMarketingConsentStatus.PatchAudienceContactRequestEmailChannelMarketingConsentStatusSerializer)
)]
[Serializable]
public readonly record struct PatchAudienceContactRequestEmailChannelMarketingConsentStatus
    : IStringEnum
{
    public static readonly PatchAudienceContactRequestEmailChannelMarketingConsentStatus Consented =
        new(Values.Consented);

    public static readonly PatchAudienceContactRequestEmailChannelMarketingConsentStatus Denied =
        new(Values.Denied);

    public static readonly PatchAudienceContactRequestEmailChannelMarketingConsentStatus Confirmed =
        new(Values.Confirmed);

    public static readonly PatchAudienceContactRequestEmailChannelMarketingConsentStatus Unknown =
        new(Values.Unknown);

    public PatchAudienceContactRequestEmailChannelMarketingConsentStatus(string value)
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
    public static PatchAudienceContactRequestEmailChannelMarketingConsentStatus FromCustom(
        string value
    )
    {
        return new PatchAudienceContactRequestEmailChannelMarketingConsentStatus(value);
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
        PatchAudienceContactRequestEmailChannelMarketingConsentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PatchAudienceContactRequestEmailChannelMarketingConsentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PatchAudienceContactRequestEmailChannelMarketingConsentStatus value
    ) => value.Value;

    public static explicit operator PatchAudienceContactRequestEmailChannelMarketingConsentStatus(
        string value
    ) => new(value);

    internal class PatchAudienceContactRequestEmailChannelMarketingConsentStatusSerializer
        : JsonConverter<PatchAudienceContactRequestEmailChannelMarketingConsentStatus>
    {
        public override PatchAudienceContactRequestEmailChannelMarketingConsentStatus Read(
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
            return new PatchAudienceContactRequestEmailChannelMarketingConsentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestEmailChannelMarketingConsentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatchAudienceContactRequestEmailChannelMarketingConsentStatus ReadAsPropertyName(
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
            return new PatchAudienceContactRequestEmailChannelMarketingConsentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestEmailChannelMarketingConsentStatus value,
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
