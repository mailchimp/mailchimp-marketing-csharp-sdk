using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListConversationsResponseLinksItemMethod.ListConversationsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListConversationsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListConversationsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListConversationsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListConversationsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListConversationsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListConversationsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListConversationsResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListConversationsResponseLinksItemMethod Head = new(Values.Head);

    public ListConversationsResponseLinksItemMethod(string value)
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
    public static ListConversationsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListConversationsResponseLinksItemMethod(value);
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
        ListConversationsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListConversationsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListConversationsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListConversationsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListConversationsResponseLinksItemMethodSerializer
        : JsonConverter<ListConversationsResponseLinksItemMethod>
    {
        public override ListConversationsResponseLinksItemMethod Read(
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
            return new ListConversationsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListConversationsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListConversationsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListConversationsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListConversationsResponseLinksItemMethod value,
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
