using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignRssOptsFrequency.CampaignRssOptsFrequencySerializer))]
[Serializable]
public readonly record struct CampaignRssOptsFrequency : IStringEnum
{
    public static readonly CampaignRssOptsFrequency Daily = new(Values.Daily);

    public static readonly CampaignRssOptsFrequency Weekly = new(Values.Weekly);

    public static readonly CampaignRssOptsFrequency Monthly = new(Values.Monthly);

    public CampaignRssOptsFrequency(string value)
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
    public static CampaignRssOptsFrequency FromCustom(string value)
    {
        return new CampaignRssOptsFrequency(value);
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

    public static bool operator ==(CampaignRssOptsFrequency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignRssOptsFrequency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignRssOptsFrequency value) => value.Value;

    public static explicit operator CampaignRssOptsFrequency(string value) => new(value);

    internal class CampaignRssOptsFrequencySerializer : JsonConverter<CampaignRssOptsFrequency>
    {
        public override CampaignRssOptsFrequency Read(
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
            return new CampaignRssOptsFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignRssOptsFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignRssOptsFrequency ReadAsPropertyName(
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
            return new CampaignRssOptsFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignRssOptsFrequency value,
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
