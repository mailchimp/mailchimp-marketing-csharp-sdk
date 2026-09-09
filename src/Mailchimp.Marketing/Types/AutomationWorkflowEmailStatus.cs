using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(AutomationWorkflowEmailStatus.AutomationWorkflowEmailStatusSerializer))]
[Serializable]
public readonly record struct AutomationWorkflowEmailStatus : IStringEnum
{
    public static readonly AutomationWorkflowEmailStatus Save = new(Values.Save);

    public static readonly AutomationWorkflowEmailStatus Paused = new(Values.Paused);

    public static readonly AutomationWorkflowEmailStatus Sending = new(Values.Sending);

    public AutomationWorkflowEmailStatus(string value)
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
    public static AutomationWorkflowEmailStatus FromCustom(string value)
    {
        return new AutomationWorkflowEmailStatus(value);
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

    public static bool operator ==(AutomationWorkflowEmailStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AutomationWorkflowEmailStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AutomationWorkflowEmailStatus value) => value.Value;

    public static explicit operator AutomationWorkflowEmailStatus(string value) => new(value);

    internal class AutomationWorkflowEmailStatusSerializer
        : JsonConverter<AutomationWorkflowEmailStatus>
    {
        public override AutomationWorkflowEmailStatus Read(
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
            return new AutomationWorkflowEmailStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowEmailStatus ReadAsPropertyName(
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
            return new AutomationWorkflowEmailStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailStatus value,
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
