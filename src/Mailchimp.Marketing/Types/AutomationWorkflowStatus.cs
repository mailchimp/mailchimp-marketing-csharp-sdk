using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(AutomationWorkflowStatus.AutomationWorkflowStatusSerializer))]
[Serializable]
public readonly record struct AutomationWorkflowStatus : IStringEnum
{
    public static readonly AutomationWorkflowStatus Save = new(Values.Save);

    public static readonly AutomationWorkflowStatus Paused = new(Values.Paused);

    public static readonly AutomationWorkflowStatus Sending = new(Values.Sending);

    public AutomationWorkflowStatus(string value)
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
    public static AutomationWorkflowStatus FromCustom(string value)
    {
        return new AutomationWorkflowStatus(value);
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

    public static bool operator ==(AutomationWorkflowStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AutomationWorkflowStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AutomationWorkflowStatus value) => value.Value;

    public static explicit operator AutomationWorkflowStatus(string value) => new(value);

    internal class AutomationWorkflowStatusSerializer : JsonConverter<AutomationWorkflowStatus>
    {
        public override AutomationWorkflowStatus Read(
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
            return new AutomationWorkflowStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowStatus ReadAsPropertyName(
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
            return new AutomationWorkflowStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowStatus value,
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
