using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateEmailAutomationsRequestDelayType.UpdateEmailAutomationsRequestDelayTypeSerializer)
)]
[Serializable]
public readonly record struct UpdateEmailAutomationsRequestDelayType : IStringEnum
{
    public static readonly UpdateEmailAutomationsRequestDelayType Now = new(Values.Now);

    public static readonly UpdateEmailAutomationsRequestDelayType Day = new(Values.Day);

    public static readonly UpdateEmailAutomationsRequestDelayType Hour = new(Values.Hour);

    public static readonly UpdateEmailAutomationsRequestDelayType Week = new(Values.Week);

    public UpdateEmailAutomationsRequestDelayType(string value)
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
    public static UpdateEmailAutomationsRequestDelayType FromCustom(string value)
    {
        return new UpdateEmailAutomationsRequestDelayType(value);
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

    public static bool operator ==(UpdateEmailAutomationsRequestDelayType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateEmailAutomationsRequestDelayType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateEmailAutomationsRequestDelayType value) =>
        value.Value;

    public static explicit operator UpdateEmailAutomationsRequestDelayType(string value) =>
        new(value);

    internal class UpdateEmailAutomationsRequestDelayTypeSerializer
        : JsonConverter<UpdateEmailAutomationsRequestDelayType>
    {
        public override UpdateEmailAutomationsRequestDelayType Read(
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
            return new UpdateEmailAutomationsRequestDelayType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateEmailAutomationsRequestDelayType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateEmailAutomationsRequestDelayType ReadAsPropertyName(
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
            return new UpdateEmailAutomationsRequestDelayType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateEmailAutomationsRequestDelayType value,
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
