using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateAutomationsRequestTriggerSettingsWorkflowType.CreateAutomationsRequestTriggerSettingsWorkflowTypeSerializer)
)]
[Serializable]
public readonly record struct CreateAutomationsRequestTriggerSettingsWorkflowType : IStringEnum
{
    public static readonly CreateAutomationsRequestTriggerSettingsWorkflowType AbandonedBrowse =
        new(Values.AbandonedBrowse);

    public static readonly CreateAutomationsRequestTriggerSettingsWorkflowType AbandonedCart = new(
        Values.AbandonedCart
    );

    public static readonly CreateAutomationsRequestTriggerSettingsWorkflowType EmailFollowup = new(
        Values.EmailFollowup
    );

    public static readonly CreateAutomationsRequestTriggerSettingsWorkflowType SingleWelcome = new(
        Values.SingleWelcome
    );

    public CreateAutomationsRequestTriggerSettingsWorkflowType(string value)
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
    public static CreateAutomationsRequestTriggerSettingsWorkflowType FromCustom(string value)
    {
        return new CreateAutomationsRequestTriggerSettingsWorkflowType(value);
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
        CreateAutomationsRequestTriggerSettingsWorkflowType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateAutomationsRequestTriggerSettingsWorkflowType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateAutomationsRequestTriggerSettingsWorkflowType value
    ) => value.Value;

    public static explicit operator CreateAutomationsRequestTriggerSettingsWorkflowType(
        string value
    ) => new(value);

    internal class CreateAutomationsRequestTriggerSettingsWorkflowTypeSerializer
        : JsonConverter<CreateAutomationsRequestTriggerSettingsWorkflowType>
    {
        public override CreateAutomationsRequestTriggerSettingsWorkflowType Read(
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
            return new CreateAutomationsRequestTriggerSettingsWorkflowType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateAutomationsRequestTriggerSettingsWorkflowType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateAutomationsRequestTriggerSettingsWorkflowType ReadAsPropertyName(
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
            return new CreateAutomationsRequestTriggerSettingsWorkflowType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateAutomationsRequestTriggerSettingsWorkflowType value,
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
        public const string AbandonedBrowse = "abandonedBrowse";

        public const string AbandonedCart = "abandonedCart";

        public const string EmailFollowup = "emailFollowup";

        public const string SingleWelcome = "singleWelcome";
    }
}
