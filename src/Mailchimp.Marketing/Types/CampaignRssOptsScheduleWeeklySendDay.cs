using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CampaignRssOptsScheduleWeeklySendDay.CampaignRssOptsScheduleWeeklySendDaySerializer)
)]
[Serializable]
public readonly record struct CampaignRssOptsScheduleWeeklySendDay : IStringEnum
{
    public static readonly CampaignRssOptsScheduleWeeklySendDay Sunday = new(Values.Sunday);

    public static readonly CampaignRssOptsScheduleWeeklySendDay Monday = new(Values.Monday);

    public static readonly CampaignRssOptsScheduleWeeklySendDay Tuesday = new(Values.Tuesday);

    public static readonly CampaignRssOptsScheduleWeeklySendDay Wednesday = new(Values.Wednesday);

    public static readonly CampaignRssOptsScheduleWeeklySendDay Thursday = new(Values.Thursday);

    public static readonly CampaignRssOptsScheduleWeeklySendDay Friday = new(Values.Friday);

    public static readonly CampaignRssOptsScheduleWeeklySendDay Saturday = new(Values.Saturday);

    public CampaignRssOptsScheduleWeeklySendDay(string value)
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
    public static CampaignRssOptsScheduleWeeklySendDay FromCustom(string value)
    {
        return new CampaignRssOptsScheduleWeeklySendDay(value);
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

    public static bool operator ==(CampaignRssOptsScheduleWeeklySendDay value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignRssOptsScheduleWeeklySendDay value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignRssOptsScheduleWeeklySendDay value) =>
        value.Value;

    public static explicit operator CampaignRssOptsScheduleWeeklySendDay(string value) =>
        new(value);

    internal class CampaignRssOptsScheduleWeeklySendDaySerializer
        : JsonConverter<CampaignRssOptsScheduleWeeklySendDay>
    {
        public override CampaignRssOptsScheduleWeeklySendDay Read(
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
            return new CampaignRssOptsScheduleWeeklySendDay(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignRssOptsScheduleWeeklySendDay value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignRssOptsScheduleWeeklySendDay ReadAsPropertyName(
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
            return new CampaignRssOptsScheduleWeeklySendDay(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignRssOptsScheduleWeeklySendDay value,
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
        public const string Sunday = "sunday";

        public const string Monday = "monday";

        public const string Tuesday = "tuesday";

        public const string Wednesday = "wednesday";

        public const string Thursday = "thursday";

        public const string Friday = "friday";

        public const string Saturday = "saturday";
    }
}
