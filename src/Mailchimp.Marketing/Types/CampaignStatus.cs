using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignStatus.CampaignStatusSerializer))]
[Serializable]
public readonly record struct CampaignStatus : IStringEnum
{
    public static readonly CampaignStatus Save = new(Values.Save);

    public static readonly CampaignStatus Paused = new(Values.Paused);

    public static readonly CampaignStatus Schedule = new(Values.Schedule);

    public static readonly CampaignStatus Sending = new(Values.Sending);

    public static readonly CampaignStatus Sent = new(Values.Sent);

    public static readonly CampaignStatus Canceled = new(Values.Canceled);

    public static readonly CampaignStatus Canceling = new(Values.Canceling);

    public static readonly CampaignStatus Archived = new(Values.Archived);

    public CampaignStatus(string value)
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
    public static CampaignStatus FromCustom(string value)
    {
        return new CampaignStatus(value);
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

    public static bool operator ==(CampaignStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignStatus value) => value.Value;

    public static explicit operator CampaignStatus(string value) => new(value);

    internal class CampaignStatusSerializer : JsonConverter<CampaignStatus>
    {
        public override CampaignStatus Read(
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
            return new CampaignStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignStatus ReadAsPropertyName(
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
            return new CampaignStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignStatus value,
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
