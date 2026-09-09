using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemCampaignPollField.SegmentTypeItemCampaignPollFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemCampaignPollField : IStringEnum
{
    public static readonly SegmentTypeItemCampaignPollField Poll = new(Values.Poll);

    public SegmentTypeItemCampaignPollField(string value)
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
    public static SegmentTypeItemCampaignPollField FromCustom(string value)
    {
        return new SegmentTypeItemCampaignPollField(value);
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

    public static bool operator ==(SegmentTypeItemCampaignPollField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemCampaignPollField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemCampaignPollField value) => value.Value;

    public static explicit operator SegmentTypeItemCampaignPollField(string value) => new(value);

    internal class SegmentTypeItemCampaignPollFieldSerializer
        : JsonConverter<SegmentTypeItemCampaignPollField>
    {
        public override SegmentTypeItemCampaignPollField Read(
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
            return new SegmentTypeItemCampaignPollField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemCampaignPollField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemCampaignPollField ReadAsPropertyName(
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
            return new SegmentTypeItemCampaignPollField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemCampaignPollField value,
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
        public const string Poll = "poll";
    }
}
