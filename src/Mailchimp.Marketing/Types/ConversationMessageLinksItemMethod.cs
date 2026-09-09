using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ConversationMessageLinksItemMethod.ConversationMessageLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ConversationMessageLinksItemMethod : IStringEnum
{
    public static readonly ConversationMessageLinksItemMethod Get = new(Values.Get);

    public static readonly ConversationMessageLinksItemMethod Post = new(Values.Post);

    public static readonly ConversationMessageLinksItemMethod Put = new(Values.Put);

    public static readonly ConversationMessageLinksItemMethod Patch = new(Values.Patch);

    public static readonly ConversationMessageLinksItemMethod Delete = new(Values.Delete);

    public static readonly ConversationMessageLinksItemMethod Options = new(Values.Options);

    public static readonly ConversationMessageLinksItemMethod Head = new(Values.Head);

    public ConversationMessageLinksItemMethod(string value)
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
    public static ConversationMessageLinksItemMethod FromCustom(string value)
    {
        return new ConversationMessageLinksItemMethod(value);
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

    public static bool operator ==(ConversationMessageLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ConversationMessageLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ConversationMessageLinksItemMethod value) => value.Value;

    public static explicit operator ConversationMessageLinksItemMethod(string value) => new(value);

    internal class ConversationMessageLinksItemMethodSerializer
        : JsonConverter<ConversationMessageLinksItemMethod>
    {
        public override ConversationMessageLinksItemMethod Read(
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
            return new ConversationMessageLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConversationMessageLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConversationMessageLinksItemMethod ReadAsPropertyName(
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
            return new ConversationMessageLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConversationMessageLinksItemMethod value,
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
