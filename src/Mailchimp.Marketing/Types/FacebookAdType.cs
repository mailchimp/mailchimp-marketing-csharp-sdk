using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(FacebookAdType.FacebookAdTypeSerializer))]
[Serializable]
public readonly record struct FacebookAdType : IStringEnum
{
    public static readonly FacebookAdType Regular = new(Values.Regular);

    public static readonly FacebookAdType EmailTouchpoint = new(Values.EmailTouchpoint);

    public static readonly FacebookAdType Plaintext = new(Values.Plaintext);

    public static readonly FacebookAdType Rss = new(Values.Rss);

    public static readonly FacebookAdType Reconfirm = new(Values.Reconfirm);

    public static readonly FacebookAdType Variate = new(Values.Variate);

    public static readonly FacebookAdType Absplit = new(Values.Absplit);

    public static readonly FacebookAdType Automation = new(Values.Automation);

    public static readonly FacebookAdType Facebook = new(Values.Facebook);

    public static readonly FacebookAdType Google = new(Values.Google);

    public static readonly FacebookAdType Autoresponder = new(Values.Autoresponder);

    public static readonly FacebookAdType Transactional = new(Values.Transactional);

    public static readonly FacebookAdType Page = new(Values.Page);

    public static readonly FacebookAdType Website = new(Values.Website);

    public static readonly FacebookAdType SocialPost = new(Values.SocialPost);

    public static readonly FacebookAdType Survey = new(Values.Survey);

    public static readonly FacebookAdType CustomerJourney = new(Values.CustomerJourney);

    public static readonly FacebookAdType Sms = new(Values.Sms);

    public FacebookAdType(string value)
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
    public static FacebookAdType FromCustom(string value)
    {
        return new FacebookAdType(value);
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

    public static bool operator ==(FacebookAdType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FacebookAdType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FacebookAdType value) => value.Value;

    public static explicit operator FacebookAdType(string value) => new(value);

    internal class FacebookAdTypeSerializer : JsonConverter<FacebookAdType>
    {
        public override FacebookAdType Read(
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
            return new FacebookAdType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FacebookAdType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FacebookAdType ReadAsPropertyName(
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
            return new FacebookAdType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FacebookAdType value,
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
        public const string Regular = "regular";

        public const string EmailTouchpoint = "email-touchpoint";

        public const string Plaintext = "plaintext";

        public const string Rss = "rss";

        public const string Reconfirm = "reconfirm";

        public const string Variate = "variate";

        public const string Absplit = "absplit";

        public const string Automation = "automation";

        public const string Facebook = "facebook";

        public const string Google = "google";

        public const string Autoresponder = "autoresponder";

        public const string Transactional = "transactional";

        public const string Page = "page";

        public const string Website = "website";

        public const string SocialPost = "social_post";

        public const string Survey = "survey";

        public const string CustomerJourney = "customer_journey";

        public const string Sms = "sms";
    }
}
