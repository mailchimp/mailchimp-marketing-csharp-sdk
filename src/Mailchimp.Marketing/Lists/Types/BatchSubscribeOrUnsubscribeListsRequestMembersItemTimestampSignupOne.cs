using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne.BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOneSerializer)
)]
[Serializable]
public readonly record struct BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne
    : IStringEnum
{
    public static readonly BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne Empty =
        new(Values.Empty);

    public BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne(string value)
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
    public static BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne FromCustom(
        string value
    )
    {
        return new BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne(value);
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
        BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne value
    ) => value.Value;

    public static explicit operator BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne(
        string value
    ) => new(value);

    internal class BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOneSerializer
        : JsonConverter<BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne>
    {
        public override BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne Read(
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
            return new BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne ReadAsPropertyName(
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
            return new BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BatchSubscribeOrUnsubscribeListsRequestMembersItemTimestampSignupOne value,
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
        public const string Empty = "";
    }
}
