using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CampaignsResendShortcutUsageShortcutCampaignsItemStatus.CampaignsResendShortcutUsageShortcutCampaignsItemStatusSerializer)
)]
[Serializable]
public readonly record struct CampaignsResendShortcutUsageShortcutCampaignsItemStatus : IStringEnum
{
    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Save = new(
        Values.Save
    );

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Paused = new(
        Values.Paused
    );

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Schedule = new(
        Values.Schedule
    );

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Sending = new(
        Values.Sending
    );

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Sent = new(
        Values.Sent
    );

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Canceled = new(
        Values.Canceled
    );

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Canceling = new(
        Values.Canceling
    );

    public static readonly CampaignsResendShortcutUsageShortcutCampaignsItemStatus Archived = new(
        Values.Archived
    );

    public CampaignsResendShortcutUsageShortcutCampaignsItemStatus(string value)
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
    public static CampaignsResendShortcutUsageShortcutCampaignsItemStatus FromCustom(string value)
    {
        return new CampaignsResendShortcutUsageShortcutCampaignsItemStatus(value);
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
        CampaignsResendShortcutUsageShortcutCampaignsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignsResendShortcutUsageShortcutCampaignsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignsResendShortcutUsageShortcutCampaignsItemStatus value
    ) => value.Value;

    public static explicit operator CampaignsResendShortcutUsageShortcutCampaignsItemStatus(
        string value
    ) => new(value);

    internal class CampaignsResendShortcutUsageShortcutCampaignsItemStatusSerializer
        : JsonConverter<CampaignsResendShortcutUsageShortcutCampaignsItemStatus>
    {
        public override CampaignsResendShortcutUsageShortcutCampaignsItemStatus Read(
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
            return new CampaignsResendShortcutUsageShortcutCampaignsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsResendShortcutUsageShortcutCampaignsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsResendShortcutUsageShortcutCampaignsItemStatus ReadAsPropertyName(
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
            return new CampaignsResendShortcutUsageShortcutCampaignsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsResendShortcutUsageShortcutCampaignsItemStatus value,
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
        public const string Save = "save";

        public const string Paused = "paused";

        public const string Schedule = "schedule";

        public const string Sending = "sending";

        public const string Sent = "sent";

        public const string Canceled = "canceled";

        public const string Canceling = "canceling";

        public const string Archived = "archived";
    }
}
