using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateCampaignsRequestRssOptsScheduleWeeklySendDay.CreateCampaignsRequestRssOptsScheduleWeeklySendDaySerializer)
)]
[Serializable]
public readonly record struct CreateCampaignsRequestRssOptsScheduleWeeklySendDay : IStringEnum
{
    public static readonly CreateCampaignsRequestRssOptsScheduleWeeklySendDay Sunday = new(
        Values.Sunday
    );

    public static readonly CreateCampaignsRequestRssOptsScheduleWeeklySendDay Monday = new(
        Values.Monday
    );

    public static readonly CreateCampaignsRequestRssOptsScheduleWeeklySendDay Tuesday = new(
        Values.Tuesday
    );

    public static readonly CreateCampaignsRequestRssOptsScheduleWeeklySendDay Wednesday = new(
        Values.Wednesday
    );

    public static readonly CreateCampaignsRequestRssOptsScheduleWeeklySendDay Thursday = new(
        Values.Thursday
    );

    public static readonly CreateCampaignsRequestRssOptsScheduleWeeklySendDay Friday = new(
        Values.Friday
    );

    public static readonly CreateCampaignsRequestRssOptsScheduleWeeklySendDay Saturday = new(
        Values.Saturday
    );

    public CreateCampaignsRequestRssOptsScheduleWeeklySendDay(string value)
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
    public static CreateCampaignsRequestRssOptsScheduleWeeklySendDay FromCustom(string value)
    {
        return new CreateCampaignsRequestRssOptsScheduleWeeklySendDay(value);
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

    public static bool operator ==(
        CreateCampaignsRequestRssOptsScheduleWeeklySendDay value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateCampaignsRequestRssOptsScheduleWeeklySendDay value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateCampaignsRequestRssOptsScheduleWeeklySendDay value
    ) => value.Value;

    public static explicit operator CreateCampaignsRequestRssOptsScheduleWeeklySendDay(
        string value
    ) => new(value);

    internal class CreateCampaignsRequestRssOptsScheduleWeeklySendDaySerializer
        : JsonConverter<CreateCampaignsRequestRssOptsScheduleWeeklySendDay>
    {
        public override CreateCampaignsRequestRssOptsScheduleWeeklySendDay Read(
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
            return new CreateCampaignsRequestRssOptsScheduleWeeklySendDay(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateCampaignsRequestRssOptsScheduleWeeklySendDay value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateCampaignsRequestRssOptsScheduleWeeklySendDay ReadAsPropertyName(
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
            return new CreateCampaignsRequestRssOptsScheduleWeeklySendDay(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateCampaignsRequestRssOptsScheduleWeeklySendDay value,
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
