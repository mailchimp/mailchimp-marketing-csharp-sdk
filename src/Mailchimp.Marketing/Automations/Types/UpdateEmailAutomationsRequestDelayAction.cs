using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateEmailAutomationsRequestDelayAction.UpdateEmailAutomationsRequestDelayActionSerializer)
)]
[Serializable]
public readonly record struct UpdateEmailAutomationsRequestDelayAction : IStringEnum
{
    public static readonly UpdateEmailAutomationsRequestDelayAction Signup = new(Values.Signup);

    public static readonly UpdateEmailAutomationsRequestDelayAction EcommAbandonedBrowse = new(
        Values.EcommAbandonedBrowse
    );

    public static readonly UpdateEmailAutomationsRequestDelayAction EcommAbandonedCart = new(
        Values.EcommAbandonedCart
    );

    public UpdateEmailAutomationsRequestDelayAction(string value)
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
    public static UpdateEmailAutomationsRequestDelayAction FromCustom(string value)
    {
        return new UpdateEmailAutomationsRequestDelayAction(value);
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
        UpdateEmailAutomationsRequestDelayAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateEmailAutomationsRequestDelayAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateEmailAutomationsRequestDelayAction value) =>
        value.Value;

    public static explicit operator UpdateEmailAutomationsRequestDelayAction(string value) =>
        new(value);

    internal class UpdateEmailAutomationsRequestDelayActionSerializer
        : JsonConverter<UpdateEmailAutomationsRequestDelayAction>
    {
        public override UpdateEmailAutomationsRequestDelayAction Read(
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
            return new UpdateEmailAutomationsRequestDelayAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateEmailAutomationsRequestDelayAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateEmailAutomationsRequestDelayAction ReadAsPropertyName(
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
            return new UpdateEmailAutomationsRequestDelayAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateEmailAutomationsRequestDelayAction value,
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
        public const string Signup = "signup";

        public const string EcommAbandonedBrowse = "ecomm_abandoned_browse";

        public const string EcommAbandonedCart = "ecomm_abandoned_cart";
    }
}
