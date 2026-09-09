using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignsType.CampaignsTypeSerializer))]
[Serializable]
public readonly record struct CampaignsType : IStringEnum
{
    public static readonly CampaignsType Regular = new(Values.Regular);

    public static readonly CampaignsType Plaintext = new(Values.Plaintext);

    public static readonly CampaignsType Absplit = new(Values.Absplit);

    public static readonly CampaignsType Rss = new(Values.Rss);

    public static readonly CampaignsType Variate = new(Values.Variate);

    public CampaignsType(string value)
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
    public static CampaignsType FromCustom(string value)
    {
        return new CampaignsType(value);
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

    public static bool operator ==(CampaignsType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignsType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignsType value) => value.Value;

    public static explicit operator CampaignsType(string value) => new(value);

    internal class CampaignsTypeSerializer : JsonConverter<CampaignsType>
    {
        public override CampaignsType Read(
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
            return new CampaignsType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsType ReadAsPropertyName(
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
            return new CampaignsType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsType value,
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
