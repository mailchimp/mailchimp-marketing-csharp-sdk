using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SentToStatus.SentToStatusSerializer))]
[Serializable]
public readonly record struct SentToStatus : IStringEnum
{
    public static readonly SentToStatus Sent = new(Values.Sent);

    public static readonly SentToStatus Hard = new(Values.Hard);

    public static readonly SentToStatus Soft = new(Values.Soft);

    public SentToStatus(string value)
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
    public static SentToStatus FromCustom(string value)
    {
        return new SentToStatus(value);
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

    public static bool operator ==(SentToStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SentToStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SentToStatus value) => value.Value;

    public static explicit operator SentToStatus(string value) => new(value);

    internal class SentToStatusSerializer : JsonConverter<SentToStatus>
    {
        public override SentToStatus Read(
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
            return new SentToStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SentToStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SentToStatus ReadAsPropertyName(
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
            return new SentToStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SentToStatus value,
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
        public const string Sent = "sent";

        public const string Hard = "hard";

        public const string Soft = "soft";
    }
}
