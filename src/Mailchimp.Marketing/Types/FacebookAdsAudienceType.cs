using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(FacebookAdsAudienceType.FacebookAdsAudienceTypeSerializer))]
[Serializable]
public readonly record struct FacebookAdsAudienceType : IStringEnum
{
    public static readonly FacebookAdsAudienceType CustomAudience = new(Values.CustomAudience);

    public static readonly FacebookAdsAudienceType LookalikeAudience = new(
        Values.LookalikeAudience
    );

    public static readonly FacebookAdsAudienceType InterestBasedAudience = new(
        Values.InterestBasedAudience
    );

    public FacebookAdsAudienceType(string value)
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
    public static FacebookAdsAudienceType FromCustom(string value)
    {
        return new FacebookAdsAudienceType(value);
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

    public static bool operator ==(FacebookAdsAudienceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FacebookAdsAudienceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FacebookAdsAudienceType value) => value.Value;

    public static explicit operator FacebookAdsAudienceType(string value) => new(value);

    internal class FacebookAdsAudienceTypeSerializer : JsonConverter<FacebookAdsAudienceType>
    {
        public override FacebookAdsAudienceType Read(
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
            return new FacebookAdsAudienceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FacebookAdsAudienceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FacebookAdsAudienceType ReadAsPropertyName(
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
            return new FacebookAdsAudienceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FacebookAdsAudienceType value,
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
        public const string CustomAudience = "Custom Audience";

        public const string LookalikeAudience = "Lookalike Audience";

        public const string InterestBasedAudience = "Interest-based Audience";
    }
}
