using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AudiencesContactSmsChannelEffectiveSubscriptionStatusValue.AudiencesContactSmsChannelEffectiveSubscriptionStatusValueSerializer)
)]
[Serializable]
public readonly record struct AudiencesContactSmsChannelEffectiveSubscriptionStatusValue
    : IStringEnum
{
    public static readonly AudiencesContactSmsChannelEffectiveSubscriptionStatusValue Subscribed =
        new(Values.Subscribed);

    public static readonly AudiencesContactSmsChannelEffectiveSubscriptionStatusValue Unsubscribed =
        new(Values.Unsubscribed);

    public static readonly AudiencesContactSmsChannelEffectiveSubscriptionStatusValue Nonsubscribed =
        new(Values.Nonsubscribed);

    public static readonly AudiencesContactSmsChannelEffectiveSubscriptionStatusValue Pending = new(
        Values.Pending
    );

    public AudiencesContactSmsChannelEffectiveSubscriptionStatusValue(string value)
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
    public static AudiencesContactSmsChannelEffectiveSubscriptionStatusValue FromCustom(
        string value
    )
    {
        return new AudiencesContactSmsChannelEffectiveSubscriptionStatusValue(value);
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
        AudiencesContactSmsChannelEffectiveSubscriptionStatusValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AudiencesContactSmsChannelEffectiveSubscriptionStatusValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AudiencesContactSmsChannelEffectiveSubscriptionStatusValue value
    ) => value.Value;

    public static explicit operator AudiencesContactSmsChannelEffectiveSubscriptionStatusValue(
        string value
    ) => new(value);

    internal class AudiencesContactSmsChannelEffectiveSubscriptionStatusValueSerializer
        : JsonConverter<AudiencesContactSmsChannelEffectiveSubscriptionStatusValue>
    {
        public override AudiencesContactSmsChannelEffectiveSubscriptionStatusValue Read(
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
            return new AudiencesContactSmsChannelEffectiveSubscriptionStatusValue(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AudiencesContactSmsChannelEffectiveSubscriptionStatusValue value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AudiencesContactSmsChannelEffectiveSubscriptionStatusValue ReadAsPropertyName(
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
            return new AudiencesContactSmsChannelEffectiveSubscriptionStatusValue(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AudiencesContactSmsChannelEffectiveSubscriptionStatusValue value,
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
        public const string Subscribed = "subscribed";

        public const string Unsubscribed = "unsubscribed";

        public const string Nonsubscribed = "nonsubscribed";

        public const string Pending = "pending";
    }
}
