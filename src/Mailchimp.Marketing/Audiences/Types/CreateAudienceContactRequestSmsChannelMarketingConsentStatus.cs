using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateAudienceContactRequestSmsChannelMarketingConsentStatus.CreateAudienceContactRequestSmsChannelMarketingConsentStatusSerializer)
)]
[Serializable]
public readonly record struct CreateAudienceContactRequestSmsChannelMarketingConsentStatus
    : IStringEnum
{
    public static readonly CreateAudienceContactRequestSmsChannelMarketingConsentStatus Consented =
        new(Values.Consented);

    public static readonly CreateAudienceContactRequestSmsChannelMarketingConsentStatus Confirmed =
        new(Values.Confirmed);

    public static readonly CreateAudienceContactRequestSmsChannelMarketingConsentStatus Unknown =
        new(Values.Unknown);

    public CreateAudienceContactRequestSmsChannelMarketingConsentStatus(string value)
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
    public static CreateAudienceContactRequestSmsChannelMarketingConsentStatus FromCustom(
        string value
    )
    {
        return new CreateAudienceContactRequestSmsChannelMarketingConsentStatus(value);
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
        CreateAudienceContactRequestSmsChannelMarketingConsentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateAudienceContactRequestSmsChannelMarketingConsentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateAudienceContactRequestSmsChannelMarketingConsentStatus value
    ) => value.Value;

    public static explicit operator CreateAudienceContactRequestSmsChannelMarketingConsentStatus(
        string value
    ) => new(value);

    internal class CreateAudienceContactRequestSmsChannelMarketingConsentStatusSerializer
        : JsonConverter<CreateAudienceContactRequestSmsChannelMarketingConsentStatus>
    {
        public override CreateAudienceContactRequestSmsChannelMarketingConsentStatus Read(
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
            return new CreateAudienceContactRequestSmsChannelMarketingConsentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateAudienceContactRequestSmsChannelMarketingConsentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateAudienceContactRequestSmsChannelMarketingConsentStatus ReadAsPropertyName(
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
            return new CreateAudienceContactRequestSmsChannelMarketingConsentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateAudienceContactRequestSmsChannelMarketingConsentStatus value,
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

        public const string Unknown = "unknown";
    }
}
