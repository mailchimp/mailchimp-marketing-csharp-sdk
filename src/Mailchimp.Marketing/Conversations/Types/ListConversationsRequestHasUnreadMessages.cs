using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListConversationsRequestHasUnreadMessages.ListConversationsRequestHasUnreadMessagesSerializer)
)]
[Serializable]
public readonly record struct ListConversationsRequestHasUnreadMessages : IStringEnum
{
    public static readonly ListConversationsRequestHasUnreadMessages True = new(Values.True);

    public static readonly ListConversationsRequestHasUnreadMessages False = new(Values.False);

    public ListConversationsRequestHasUnreadMessages(string value)
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
    public static ListConversationsRequestHasUnreadMessages FromCustom(string value)
    {
        return new ListConversationsRequestHasUnreadMessages(value);
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
        ListConversationsRequestHasUnreadMessages value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListConversationsRequestHasUnreadMessages value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListConversationsRequestHasUnreadMessages value) =>
        value.Value;

    public static explicit operator ListConversationsRequestHasUnreadMessages(string value) =>
        new(value);

    internal class ListConversationsRequestHasUnreadMessagesSerializer
        : JsonConverter<ListConversationsRequestHasUnreadMessages>
    {
        public override ListConversationsRequestHasUnreadMessages Read(
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
            return new ListConversationsRequestHasUnreadMessages(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListConversationsRequestHasUnreadMessages value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListConversationsRequestHasUnreadMessages ReadAsPropertyName(
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
            return new ListConversationsRequestHasUnreadMessages(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListConversationsRequestHasUnreadMessages value,
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
