using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateAudienceContactRequestEmailChannelMarketingConsentStatus.CreateAudienceContactRequestEmailChannelMarketingConsentStatusSerializer)
)]
[Serializable]
public readonly record struct CreateAudienceContactRequestEmailChannelMarketingConsentStatus
    : IStringEnum
{
    public static readonly CreateAudienceContactRequestEmailChannelMarketingConsentStatus Confirmed =
        new(Values.Confirmed);

    public static readonly CreateAudienceContactRequestEmailChannelMarketingConsentStatus Consented =
        new(Values.Consented);

    public static readonly CreateAudienceContactRequestEmailChannelMarketingConsentStatus Denied =
        new(Values.Denied);

    public static readonly CreateAudienceContactRequestEmailChannelMarketingConsentStatus Unknown =
        new(Values.Unknown);

    public CreateAudienceContactRequestEmailChannelMarketingConsentStatus(string value)
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
    public static CreateAudienceContactRequestEmailChannelMarketingConsentStatus FromCustom(
        string value
    )
    {
        return new CreateAudienceContactRequestEmailChannelMarketingConsentStatus(value);
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
        CreateAudienceContactRequestEmailChannelMarketingConsentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateAudienceContactRequestEmailChannelMarketingConsentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateAudienceContactRequestEmailChannelMarketingConsentStatus value
    ) => value.Value;

    public static explicit operator CreateAudienceContactRequestEmailChannelMarketingConsentStatus(
        string value
    ) => new(value);

    internal class CreateAudienceContactRequestEmailChannelMarketingConsentStatusSerializer
        : JsonConverter<CreateAudienceContactRequestEmailChannelMarketingConsentStatus>
    {
        public override CreateAudienceContactRequestEmailChannelMarketingConsentStatus Read(
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
            return new CreateAudienceContactRequestEmailChannelMarketingConsentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateAudienceContactRequestEmailChannelMarketingConsentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateAudienceContactRequestEmailChannelMarketingConsentStatus ReadAsPropertyName(
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
            return new CreateAudienceContactRequestEmailChannelMarketingConsentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateAudienceContactRequestEmailChannelMarketingConsentStatus value,
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
        public const string Confirmed = "confirmed";

        public const string Consented = "consented";

        public const string Denied = "denied";

        public const string Unknown = "unknown";
    }
}
