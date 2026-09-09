using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AutomationWorkflowEmailDelayDirection.AutomationWorkflowEmailDelayDirectionSerializer)
)]
[Serializable]
public readonly record struct AutomationWorkflowEmailDelayDirection : IStringEnum
{
    public static readonly AutomationWorkflowEmailDelayDirection Before = new(Values.Before);

    public static readonly AutomationWorkflowEmailDelayDirection After = new(Values.After);

    public AutomationWorkflowEmailDelayDirection(string value)
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
    public static AutomationWorkflowEmailDelayDirection FromCustom(string value)
    {
        return new AutomationWorkflowEmailDelayDirection(value);
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

    public static bool operator ==(AutomationWorkflowEmailDelayDirection value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AutomationWorkflowEmailDelayDirection value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AutomationWorkflowEmailDelayDirection value) =>
        value.Value;

    public static explicit operator AutomationWorkflowEmailDelayDirection(string value) =>
        new(value);

    internal class AutomationWorkflowEmailDelayDirectionSerializer
        : JsonConverter<AutomationWorkflowEmailDelayDirection>
    {
        public override AutomationWorkflowEmailDelayDirection Read(
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
            return new AutomationWorkflowEmailDelayDirection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailDelayDirection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowEmailDelayDirection ReadAsPropertyName(
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
            return new AutomationWorkflowEmailDelayDirection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailDelayDirection value,
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
        public const string Before = "before";

        public const string After = "after";
    }
}
