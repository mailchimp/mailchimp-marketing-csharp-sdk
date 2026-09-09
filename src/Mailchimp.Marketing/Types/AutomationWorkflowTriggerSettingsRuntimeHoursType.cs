using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AutomationWorkflowTriggerSettingsRuntimeHoursType.AutomationWorkflowTriggerSettingsRuntimeHoursTypeSerializer)
)]
[Serializable]
public readonly record struct AutomationWorkflowTriggerSettingsRuntimeHoursType : IStringEnum
{
    public static readonly AutomationWorkflowTriggerSettingsRuntimeHoursType SendAsap = new(
        Values.SendAsap
    );

    public static readonly AutomationWorkflowTriggerSettingsRuntimeHoursType SendBetween = new(
        Values.SendBetween
    );

    public static readonly AutomationWorkflowTriggerSettingsRuntimeHoursType SendAt = new(
        Values.SendAt
    );

    public AutomationWorkflowTriggerSettingsRuntimeHoursType(string value)
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
    public static AutomationWorkflowTriggerSettingsRuntimeHoursType FromCustom(string value)
    {
        return new AutomationWorkflowTriggerSettingsRuntimeHoursType(value);
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
        AutomationWorkflowTriggerSettingsRuntimeHoursType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationWorkflowTriggerSettingsRuntimeHoursType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AutomationWorkflowTriggerSettingsRuntimeHoursType value
    ) => value.Value;

    public static explicit operator AutomationWorkflowTriggerSettingsRuntimeHoursType(
        string value
    ) => new(value);

    internal class AutomationWorkflowTriggerSettingsRuntimeHoursTypeSerializer
        : JsonConverter<AutomationWorkflowTriggerSettingsRuntimeHoursType>
    {
        public override AutomationWorkflowTriggerSettingsRuntimeHoursType Read(
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
            return new AutomationWorkflowTriggerSettingsRuntimeHoursType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowTriggerSettingsRuntimeHoursType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowTriggerSettingsRuntimeHoursType ReadAsPropertyName(
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
            return new AutomationWorkflowTriggerSettingsRuntimeHoursType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowTriggerSettingsRuntimeHoursType value,
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
        public const string SendAsap = "send_asap";

        public const string SendBetween = "send_between";

        public const string SendAt = "send_at";
    }
}
