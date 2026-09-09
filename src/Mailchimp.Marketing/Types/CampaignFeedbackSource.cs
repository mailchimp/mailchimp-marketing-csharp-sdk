using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignFeedbackSource.CampaignFeedbackSourceSerializer))]
[Serializable]
public readonly record struct CampaignFeedbackSource : IStringEnum
{
    public static readonly CampaignFeedbackSource Api = new(Values.Api);

    public static readonly CampaignFeedbackSource Email = new(Values.Email);

    public static readonly CampaignFeedbackSource Sms = new(Values.Sms);

    public static readonly CampaignFeedbackSource Web = new(Values.Web);

    public static readonly CampaignFeedbackSource Ios = new(Values.Ios);

    public static readonly CampaignFeedbackSource Android = new(Values.Android);

    public CampaignFeedbackSource(string value)
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
    public static CampaignFeedbackSource FromCustom(string value)
    {
        return new CampaignFeedbackSource(value);
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

    public static bool operator ==(CampaignFeedbackSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignFeedbackSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignFeedbackSource value) => value.Value;

    public static explicit operator CampaignFeedbackSource(string value) => new(value);

    internal class CampaignFeedbackSourceSerializer : JsonConverter<CampaignFeedbackSource>
    {
        public override CampaignFeedbackSource Read(
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
            return new CampaignFeedbackSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignFeedbackSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignFeedbackSource ReadAsPropertyName(
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
            return new CampaignFeedbackSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignFeedbackSource value,
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
        public const string Api = "api";

        public const string Email = "email";

        public const string Sms = "sms";

        public const string Web = "web";

        public const string Ios = "ios";

        public const string Android = "android";
    }
}
