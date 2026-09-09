using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(FacebookAdsAudienceSourceType.FacebookAdsAudienceSourceTypeSerializer))]
[Serializable]
public readonly record struct FacebookAdsAudienceSourceType : IStringEnum
{
    public static readonly FacebookAdsAudienceSourceType Facebook = new(Values.Facebook);

    public static readonly FacebookAdsAudienceSourceType List = new(Values.List);

    public FacebookAdsAudienceSourceType(string value)
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
    public static FacebookAdsAudienceSourceType FromCustom(string value)
    {
        return new FacebookAdsAudienceSourceType(value);
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

    public static bool operator ==(FacebookAdsAudienceSourceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FacebookAdsAudienceSourceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FacebookAdsAudienceSourceType value) => value.Value;

    public static explicit operator FacebookAdsAudienceSourceType(string value) => new(value);

    internal class FacebookAdsAudienceSourceTypeSerializer
        : JsonConverter<FacebookAdsAudienceSourceType>
    {
        public override FacebookAdsAudienceSourceType Read(
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
            return new FacebookAdsAudienceSourceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FacebookAdsAudienceSourceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FacebookAdsAudienceSourceType ReadAsPropertyName(
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
            return new FacebookAdsAudienceSourceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FacebookAdsAudienceSourceType value,
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
        public const string Facebook = "facebook";

        public const string List = "list";
    }
}
