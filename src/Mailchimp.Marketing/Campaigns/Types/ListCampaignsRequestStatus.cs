using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListCampaignsRequestStatus.ListCampaignsRequestStatusSerializer))]
[Serializable]
public readonly record struct ListCampaignsRequestStatus : IStringEnum
{
    public static readonly ListCampaignsRequestStatus Save = new(Values.Save);

    public static readonly ListCampaignsRequestStatus Paused = new(Values.Paused);

    public static readonly ListCampaignsRequestStatus Schedule = new(Values.Schedule);

    public static readonly ListCampaignsRequestStatus Sending = new(Values.Sending);

    public static readonly ListCampaignsRequestStatus Sent = new(Values.Sent);

    public ListCampaignsRequestStatus(string value)
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
    public static ListCampaignsRequestStatus FromCustom(string value)
    {
        return new ListCampaignsRequestStatus(value);
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

    public static bool operator ==(ListCampaignsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListCampaignsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListCampaignsRequestStatus value) => value.Value;

    public static explicit operator ListCampaignsRequestStatus(string value) => new(value);

    internal class ListCampaignsRequestStatusSerializer : JsonConverter<ListCampaignsRequestStatus>
    {
        public override ListCampaignsRequestStatus Read(
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
            return new ListCampaignsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCampaignsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCampaignsRequestStatus ReadAsPropertyName(
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
            return new ListCampaignsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCampaignsRequestStatus value,
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
    }
}
