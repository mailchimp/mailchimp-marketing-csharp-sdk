using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus.BatchSubscribeOrUnsubscribeListsRequestMembersItemStatusSerializer)
)]
[Serializable]
public readonly record struct BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus : IStringEnum
{
    public static readonly BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus Subscribed =
        new(Values.Subscribed);

    public static readonly BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus Unsubscribed =
        new(Values.Unsubscribed);

    public static readonly BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus Cleaned = new(
        Values.Cleaned
    );

    public static readonly BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus Pending = new(
        Values.Pending
    );

    public static readonly BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus Transactional =
        new(Values.Transactional);

    public BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus(string value)
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
    public static BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus FromCustom(string value)
    {
        return new BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus(value);
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
        BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus value
    ) => value.Value;

    public static explicit operator BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus(
        string value
    ) => new(value);

    internal class BatchSubscribeOrUnsubscribeListsRequestMembersItemStatusSerializer
        : JsonConverter<BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus>
    {
        public override BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus Read(
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
            return new BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus ReadAsPropertyName(
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
            return new BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BatchSubscribeOrUnsubscribeListsRequestMembersItemStatus value,
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

        public const string Cleaned = "cleaned";

        public const string Pending = "pending";

        public const string Transactional = "transactional";
    }
}
