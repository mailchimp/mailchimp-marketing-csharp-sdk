using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SubscriberListVisibility.SubscriberListVisibilitySerializer))]
[Serializable]
public readonly record struct SubscriberListVisibility : IStringEnum
{
    public static readonly SubscriberListVisibility Pub = new(Values.Pub);

    public static readonly SubscriberListVisibility Prv = new(Values.Prv);

    public SubscriberListVisibility(string value)
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
    public static SubscriberListVisibility FromCustom(string value)
    {
        return new SubscriberListVisibility(value);
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

    public static bool operator ==(SubscriberListVisibility value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SubscriberListVisibility value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SubscriberListVisibility value) => value.Value;

    public static explicit operator SubscriberListVisibility(string value) => new(value);

    internal class SubscriberListVisibilitySerializer : JsonConverter<SubscriberListVisibility>
    {
        public override SubscriberListVisibility Read(
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
            return new SubscriberListVisibility(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriberListVisibility value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriberListVisibility ReadAsPropertyName(
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
            return new SubscriberListVisibility(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriberListVisibility value,
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
        public const string Pub = "pub";

        public const string Prv = "prv";
    }
}
