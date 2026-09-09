using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(AutomationWorkflowEmailTriggerSettingsRuntimeHoursType.AutomationWorkflowEmailTriggerSettingsRuntimeHoursTypeSerializer)
)]
[Serializable]
public readonly record struct AutomationWorkflowEmailTriggerSettingsRuntimeHoursType : IStringEnum
{
    public static readonly AutomationWorkflowEmailTriggerSettingsRuntimeHoursType SendAsap = new(
        Values.SendAsap
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsRuntimeHoursType SendBetween = new(
        Values.SendBetween
    );

    public static readonly AutomationWorkflowEmailTriggerSettingsRuntimeHoursType SendAt = new(
        Values.SendAt
    );

    public AutomationWorkflowEmailTriggerSettingsRuntimeHoursType(string value)
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
    public static AutomationWorkflowEmailTriggerSettingsRuntimeHoursType FromCustom(string value)
    {
        return new AutomationWorkflowEmailTriggerSettingsRuntimeHoursType(value);
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
        AutomationWorkflowEmailTriggerSettingsRuntimeHoursType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationWorkflowEmailTriggerSettingsRuntimeHoursType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AutomationWorkflowEmailTriggerSettingsRuntimeHoursType value
    ) => value.Value;

    public static explicit operator AutomationWorkflowEmailTriggerSettingsRuntimeHoursType(
        string value
    ) => new(value);

    internal class AutomationWorkflowEmailTriggerSettingsRuntimeHoursTypeSerializer
        : JsonConverter<AutomationWorkflowEmailTriggerSettingsRuntimeHoursType>
    {
        public override AutomationWorkflowEmailTriggerSettingsRuntimeHoursType Read(
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
            return new AutomationWorkflowEmailTriggerSettingsRuntimeHoursType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailTriggerSettingsRuntimeHoursType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowEmailTriggerSettingsRuntimeHoursType ReadAsPropertyName(
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
            return new AutomationWorkflowEmailTriggerSettingsRuntimeHoursType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailTriggerSettingsRuntimeHoursType value,
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
