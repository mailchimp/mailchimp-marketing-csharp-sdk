using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListAutomationsRequestStatus.ListAutomationsRequestStatusSerializer))]
[Serializable]
public readonly record struct ListAutomationsRequestStatus : IStringEnum
{
    public static readonly ListAutomationsRequestStatus Save = new(Values.Save);

    public static readonly ListAutomationsRequestStatus Paused = new(Values.Paused);

    public static readonly ListAutomationsRequestStatus Sending = new(Values.Sending);

    public ListAutomationsRequestStatus(string value)
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
    public static ListAutomationsRequestStatus FromCustom(string value)
    {
        return new ListAutomationsRequestStatus(value);
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

    public static bool operator ==(ListAutomationsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListAutomationsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListAutomationsRequestStatus value) => value.Value;

    public static explicit operator ListAutomationsRequestStatus(string value) => new(value);

    internal class ListAutomationsRequestStatusSerializer
        : JsonConverter<ListAutomationsRequestStatus>
    {
        public override ListAutomationsRequestStatus Read(
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
            return new ListAutomationsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAutomationsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAutomationsRequestStatus ReadAsPropertyName(
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
            return new ListAutomationsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAutomationsRequestStatus value,
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
        public const string Save = "save";

        public const string Paused = "paused";

        public const string Sending = "sending";
    }
}
