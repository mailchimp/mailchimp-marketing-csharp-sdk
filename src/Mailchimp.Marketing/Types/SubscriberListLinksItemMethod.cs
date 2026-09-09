using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SubscriberListLinksItemMethod.SubscriberListLinksItemMethodSerializer))]
[Serializable]
public readonly record struct SubscriberListLinksItemMethod : IStringEnum
{
    public static readonly SubscriberListLinksItemMethod Get = new(Values.Get);

    public static readonly SubscriberListLinksItemMethod Post = new(Values.Post);

    public static readonly SubscriberListLinksItemMethod Put = new(Values.Put);

    public static readonly SubscriberListLinksItemMethod Patch = new(Values.Patch);

    public static readonly SubscriberListLinksItemMethod Delete = new(Values.Delete);

    public static readonly SubscriberListLinksItemMethod Options = new(Values.Options);

    public static readonly SubscriberListLinksItemMethod Head = new(Values.Head);

    public SubscriberListLinksItemMethod(string value)
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
    public static SubscriberListLinksItemMethod FromCustom(string value)
    {
        return new SubscriberListLinksItemMethod(value);
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

    public static bool operator ==(SubscriberListLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SubscriberListLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SubscriberListLinksItemMethod value) => value.Value;

    public static explicit operator SubscriberListLinksItemMethod(string value) => new(value);

    internal class SubscriberListLinksItemMethodSerializer
        : JsonConverter<SubscriberListLinksItemMethod>
    {
        public override SubscriberListLinksItemMethod Read(
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
            return new SubscriberListLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriberListLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriberListLinksItemMethod ReadAsPropertyName(
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
            return new SubscriberListLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriberListLinksItemMethod value,
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
