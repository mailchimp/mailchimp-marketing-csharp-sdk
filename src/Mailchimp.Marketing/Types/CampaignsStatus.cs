using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignsStatus.CampaignsStatusSerializer))]
[Serializable]
public readonly record struct CampaignsStatus : IStringEnum
{
    public static readonly CampaignsStatus Save = new(Values.Save);

    public static readonly CampaignsStatus Paused = new(Values.Paused);

    public static readonly CampaignsStatus Schedule = new(Values.Schedule);

    public static readonly CampaignsStatus Sending = new(Values.Sending);

    public static readonly CampaignsStatus Sent = new(Values.Sent);

    public static readonly CampaignsStatus Canceled = new(Values.Canceled);

    public static readonly CampaignsStatus Canceling = new(Values.Canceling);

    public static readonly CampaignsStatus Archived = new(Values.Archived);

    public CampaignsStatus(string value)
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
    public static CampaignsStatus FromCustom(string value)
    {
        return new CampaignsStatus(value);
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

    public static bool operator ==(CampaignsStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignsStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignsStatus value) => value.Value;

    public static explicit operator CampaignsStatus(string value) => new(value);

    internal class CampaignsStatusSerializer : JsonConverter<CampaignsStatus>
    {
        public override CampaignsStatus Read(
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
            return new CampaignsStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsStatus ReadAsPropertyName(
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
            return new CampaignsStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsStatus value,
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
