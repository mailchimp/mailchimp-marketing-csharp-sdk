using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode.BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCodeSerializer)
)]
[Serializable]
public readonly record struct BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode
    : IStringEnum
{
    public static readonly BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode ErrorContactExists =
        new(Values.ErrorContactExists);

    public static readonly BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode ErrorGeneric =
        new(Values.ErrorGeneric);

    public BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode(string value)
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
    public static BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode FromCustom(
        string value
    )
    {
        return new BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode(value);
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
        BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode value
    ) => value.Value;

    public static explicit operator BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode(
        string value
    ) => new(value);

    internal class BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCodeSerializer
        : JsonConverter<BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode>
    {
        public override BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode Read(
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
            return new BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode ReadAsPropertyName(
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
            return new BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BatchSubscribeOrUnsubscribeListsResponseErrorsItemErrorCode value,
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
        public const string ErrorContactExists = "ERROR_CONTACT_EXISTS";

        public const string ErrorGeneric = "ERROR_GENERIC";
    }
}
