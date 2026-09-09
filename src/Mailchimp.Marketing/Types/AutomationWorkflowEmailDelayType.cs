using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(AutomationWorkflowEmailDelayType.AutomationWorkflowEmailDelayTypeSerializer))]
[Serializable]
public readonly record struct AutomationWorkflowEmailDelayType : IStringEnum
{
    public static readonly AutomationWorkflowEmailDelayType Now = new(Values.Now);

    public static readonly AutomationWorkflowEmailDelayType Day = new(Values.Day);

    public static readonly AutomationWorkflowEmailDelayType Hour = new(Values.Hour);

    public static readonly AutomationWorkflowEmailDelayType Week = new(Values.Week);

    public AutomationWorkflowEmailDelayType(string value)
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
    public static AutomationWorkflowEmailDelayType FromCustom(string value)
    {
        return new AutomationWorkflowEmailDelayType(value);
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

    public static bool operator ==(AutomationWorkflowEmailDelayType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AutomationWorkflowEmailDelayType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AutomationWorkflowEmailDelayType value) => value.Value;

    public static explicit operator AutomationWorkflowEmailDelayType(string value) => new(value);

    internal class AutomationWorkflowEmailDelayTypeSerializer
        : JsonConverter<AutomationWorkflowEmailDelayType>
    {
        public override AutomationWorkflowEmailDelayType Read(
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
            return new AutomationWorkflowEmailDelayType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailDelayType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationWorkflowEmailDelayType ReadAsPropertyName(
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
            return new AutomationWorkflowEmailDelayType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationWorkflowEmailDelayType value,
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
        public const string Now = "now";

        public const string Day = "day";

        public const string Hour = "hour";

        public const string Week = "week";
    }
}
