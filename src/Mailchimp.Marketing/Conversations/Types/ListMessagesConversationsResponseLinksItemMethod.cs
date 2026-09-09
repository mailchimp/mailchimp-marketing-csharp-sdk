using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMessagesConversationsResponseLinksItemMethod.ListMessagesConversationsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListMessagesConversationsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListMessagesConversationsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListMessagesConversationsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListMessagesConversationsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListMessagesConversationsResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListMessagesConversationsResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListMessagesConversationsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListMessagesConversationsResponseLinksItemMethod Head = new(Values.Head);

    public ListMessagesConversationsResponseLinksItemMethod(string value)
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
    public static ListMessagesConversationsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListMessagesConversationsResponseLinksItemMethod(value);
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
        ListMessagesConversationsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListMessagesConversationsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListMessagesConversationsResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListMessagesConversationsResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListMessagesConversationsResponseLinksItemMethodSerializer
        : JsonConverter<ListMessagesConversationsResponseLinksItemMethod>
    {
        public override ListMessagesConversationsResponseLinksItemMethod Read(
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
            return new ListMessagesConversationsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMessagesConversationsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMessagesConversationsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListMessagesConversationsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMessagesConversationsResponseLinksItemMethod value,
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
        public const string Get = "GET";

        public const string Post = "POST";

        public const string Put = "PUT";

        public const string Patch = "PATCH";

        public const string Delete = "DELETE";

        public const string Options = "OPTIONS";

        public const string Head = "HEAD";
    }
}
