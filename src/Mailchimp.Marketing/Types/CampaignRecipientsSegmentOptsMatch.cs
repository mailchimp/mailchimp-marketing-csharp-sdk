using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CampaignRecipientsSegmentOptsMatch.CampaignRecipientsSegmentOptsMatchSerializer)
)]
[Serializable]
public readonly record struct CampaignRecipientsSegmentOptsMatch : IStringEnum
{
    public static readonly CampaignRecipientsSegmentOptsMatch Any = new(Values.Any);

    public static readonly CampaignRecipientsSegmentOptsMatch All = new(Values.All);

    public CampaignRecipientsSegmentOptsMatch(string value)
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
    public static CampaignRecipientsSegmentOptsMatch FromCustom(string value)
    {
        return new CampaignRecipientsSegmentOptsMatch(value);
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

    public static bool operator ==(CampaignRecipientsSegmentOptsMatch value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignRecipientsSegmentOptsMatch value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignRecipientsSegmentOptsMatch value) => value.Value;

    public static explicit operator CampaignRecipientsSegmentOptsMatch(string value) => new(value);

    internal class CampaignRecipientsSegmentOptsMatchSerializer
        : JsonConverter<CampaignRecipientsSegmentOptsMatch>
    {
        public override CampaignRecipientsSegmentOptsMatch Read(
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
            return new CampaignRecipientsSegmentOptsMatch(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignRecipientsSegmentOptsMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignRecipientsSegmentOptsMatch ReadAsPropertyName(
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
            return new CampaignRecipientsSegmentOptsMatch(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignRecipientsSegmentOptsMatch value,
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
        public const string Any = "any";

        public const string All = "all";
    }
}
