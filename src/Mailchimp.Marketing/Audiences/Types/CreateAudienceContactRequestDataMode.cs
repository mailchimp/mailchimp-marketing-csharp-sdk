using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateAudienceContactRequestDataMode.CreateAudienceContactRequestDataModeSerializer)
)]
[Serializable]
public readonly record struct CreateAudienceContactRequestDataMode : IStringEnum
{
    public static readonly CreateAudienceContactRequestDataMode Historical = new(Values.Historical);

    public static readonly CreateAudienceContactRequestDataMode Live = new(Values.Live);

    public CreateAudienceContactRequestDataMode(string value)
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
    public static CreateAudienceContactRequestDataMode FromCustom(string value)
    {
        return new CreateAudienceContactRequestDataMode(value);
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

    public static bool operator ==(CreateAudienceContactRequestDataMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateAudienceContactRequestDataMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateAudienceContactRequestDataMode value) =>
        value.Value;

    public static explicit operator CreateAudienceContactRequestDataMode(string value) =>
        new(value);

    internal class CreateAudienceContactRequestDataModeSerializer
        : JsonConverter<CreateAudienceContactRequestDataMode>
    {
        public override CreateAudienceContactRequestDataMode Read(
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
            return new CreateAudienceContactRequestDataMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateAudienceContactRequestDataMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateAudienceContactRequestDataMode ReadAsPropertyName(
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
            return new CreateAudienceContactRequestDataMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateAudienceContactRequestDataMode value,
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
        public const string Historical = "historical";

        public const string Live = "live";
    }
}
