using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemCampaignPollOp.SegmentTypeItemCampaignPollOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemCampaignPollOp : IStringEnum
{
    public static readonly SegmentTypeItemCampaignPollOp Member = new(Values.Member);

    public static readonly SegmentTypeItemCampaignPollOp Notmember = new(Values.Notmember);

    public SegmentTypeItemCampaignPollOp(string value)
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
    public static SegmentTypeItemCampaignPollOp FromCustom(string value)
    {
        return new SegmentTypeItemCampaignPollOp(value);
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

    public static bool operator ==(SegmentTypeItemCampaignPollOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemCampaignPollOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemCampaignPollOp value) => value.Value;

    public static explicit operator SegmentTypeItemCampaignPollOp(string value) => new(value);

    internal class SegmentTypeItemCampaignPollOpSerializer
        : JsonConverter<SegmentTypeItemCampaignPollOp>
    {
        public override SegmentTypeItemCampaignPollOp Read(
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
            return new SegmentTypeItemCampaignPollOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemCampaignPollOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemCampaignPollOp ReadAsPropertyName(
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
            return new SegmentTypeItemCampaignPollOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemCampaignPollOp value,
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
        public const string Member = "member";

        public const string Notmember = "notmember";
    }
}
