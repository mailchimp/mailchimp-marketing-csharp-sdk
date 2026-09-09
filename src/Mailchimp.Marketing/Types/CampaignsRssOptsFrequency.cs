using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignsRssOptsFrequency.CampaignsRssOptsFrequencySerializer))]
[Serializable]
public readonly record struct CampaignsRssOptsFrequency : IStringEnum
{
    public static readonly CampaignsRssOptsFrequency Daily = new(Values.Daily);

    public static readonly CampaignsRssOptsFrequency Weekly = new(Values.Weekly);

    public static readonly CampaignsRssOptsFrequency Monthly = new(Values.Monthly);

    public CampaignsRssOptsFrequency(string value)
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
    public static CampaignsRssOptsFrequency FromCustom(string value)
    {
        return new CampaignsRssOptsFrequency(value);
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

    public static bool operator ==(CampaignsRssOptsFrequency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignsRssOptsFrequency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignsRssOptsFrequency value) => value.Value;

    public static explicit operator CampaignsRssOptsFrequency(string value) => new(value);

    internal class CampaignsRssOptsFrequencySerializer : JsonConverter<CampaignsRssOptsFrequency>
    {
        public override CampaignsRssOptsFrequency Read(
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
            return new CampaignsRssOptsFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsRssOptsFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsRssOptsFrequency ReadAsPropertyName(
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
            return new CampaignsRssOptsFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsRssOptsFrequency value,
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
        public const string Daily = "daily";

        public const string Weekly = "weekly";

        public const string Monthly = "monthly";
    }
}
