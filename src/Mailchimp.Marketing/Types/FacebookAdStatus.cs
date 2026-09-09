using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(FacebookAdStatus.FacebookAdStatusSerializer))]
[Serializable]
public readonly record struct FacebookAdStatus : IStringEnum
{
    public static readonly FacebookAdStatus Save = new(Values.Save);

    public static readonly FacebookAdStatus Paused = new(Values.Paused);

    public static readonly FacebookAdStatus Schedule = new(Values.Schedule);

    public static readonly FacebookAdStatus Scheduled = new(Values.Scheduled);

    public static readonly FacebookAdStatus Sending = new(Values.Sending);

    public static readonly FacebookAdStatus Sent = new(Values.Sent);

    public static readonly FacebookAdStatus Canceled = new(Values.Canceled);

    public static readonly FacebookAdStatus Canceling = new(Values.Canceling);

    public static readonly FacebookAdStatus Active = new(Values.Active);

    public static readonly FacebookAdStatus Disconnected = new(Values.Disconnected);

    public static readonly FacebookAdStatus Somepaused = new(Values.Somepaused);

    public static readonly FacebookAdStatus Draft = new(Values.Draft);

    public static readonly FacebookAdStatus Completed = new(Values.Completed);

    public static readonly FacebookAdStatus PartialRejected = new(Values.PartialRejected);

    public static readonly FacebookAdStatus Pending = new(Values.Pending);

    public static readonly FacebookAdStatus Rejected = new(Values.Rejected);

    public static readonly FacebookAdStatus Published = new(Values.Published);

    public static readonly FacebookAdStatus Unpublished = new(Values.Unpublished);

    public FacebookAdStatus(string value)
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
    public static FacebookAdStatus FromCustom(string value)
    {
        return new FacebookAdStatus(value);
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

    public static bool operator ==(FacebookAdStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FacebookAdStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FacebookAdStatus value) => value.Value;

    public static explicit operator FacebookAdStatus(string value) => new(value);

    internal class FacebookAdStatusSerializer : JsonConverter<FacebookAdStatus>
    {
        public override FacebookAdStatus Read(
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
            return new FacebookAdStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FacebookAdStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FacebookAdStatus ReadAsPropertyName(
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
            return new FacebookAdStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FacebookAdStatus value,
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

        public const string Scheduled = "scheduled";

        public const string Sending = "sending";

        public const string Sent = "sent";

        public const string Canceled = "canceled";

        public const string Canceling = "canceling";

        public const string Active = "active";

        public const string Disconnected = "disconnected";

        public const string Somepaused = "somepaused";

        public const string Draft = "draft";

        public const string Completed = "completed";

        public const string PartialRejected = "partialRejected";

        public const string Pending = "pending";

        public const string Rejected = "rejected";

        public const string Published = "published";

        public const string Unpublished = "unpublished";
    }
}
