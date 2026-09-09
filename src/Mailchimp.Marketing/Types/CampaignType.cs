using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignType.CampaignTypeSerializer))]
[Serializable]
public readonly record struct CampaignType : IStringEnum
{
    public static readonly CampaignType Regular = new(Values.Regular);

    public static readonly CampaignType Plaintext = new(Values.Plaintext);

    public static readonly CampaignType Absplit = new(Values.Absplit);

    public static readonly CampaignType Rss = new(Values.Rss);

    public static readonly CampaignType Variate = new(Values.Variate);

    public CampaignType(string value)
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
    public static CampaignType FromCustom(string value)
    {
        return new CampaignType(value);
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

    public static bool operator ==(CampaignType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignType value) => value.Value;

    public static explicit operator CampaignType(string value) => new(value);

    internal class CampaignTypeSerializer : JsonConverter<CampaignType>
    {
        public override CampaignType Read(
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
            return new CampaignType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignType ReadAsPropertyName(
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
            return new CampaignType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignType value,
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

        public const string Plaintext = "plaintext";

        public const string Absplit = "absplit";

        public const string Rss = "rss";

        public const string Variate = "variate";
    }
}
