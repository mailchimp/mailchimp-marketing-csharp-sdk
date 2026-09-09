using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMessagesConversationsRequestIsRead.ListMessagesConversationsRequestIsReadSerializer)
)]
[Serializable]
public readonly record struct ListMessagesConversationsRequestIsRead : IStringEnum
{
    public static readonly ListMessagesConversationsRequestIsRead True = new(Values.True);

    public static readonly ListMessagesConversationsRequestIsRead False = new(Values.False);

    public ListMessagesConversationsRequestIsRead(string value)
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
    public static ListMessagesConversationsRequestIsRead FromCustom(string value)
    {
        return new ListMessagesConversationsRequestIsRead(value);
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

    public static bool operator ==(ListMessagesConversationsRequestIsRead value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMessagesConversationsRequestIsRead value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMessagesConversationsRequestIsRead value) =>
        value.Value;

    public static explicit operator ListMessagesConversationsRequestIsRead(string value) =>
        new(value);

    internal class ListMessagesConversationsRequestIsReadSerializer
        : JsonConverter<ListMessagesConversationsRequestIsRead>
    {
        public override ListMessagesConversationsRequestIsRead Read(
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
            return new ListMessagesConversationsRequestIsRead(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMessagesConversationsRequestIsRead value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMessagesConversationsRequestIsRead ReadAsPropertyName(
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
            return new ListMessagesConversationsRequestIsRead(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMessagesConversationsRequestIsRead value,
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
        public const string True = "true";

        public const string False = "false";
    }
}
