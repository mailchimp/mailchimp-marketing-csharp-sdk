using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(PatchAudienceContactRequestDataMode.PatchAudienceContactRequestDataModeSerializer)
)]
[Serializable]
public readonly record struct PatchAudienceContactRequestDataMode : IStringEnum
{
    public static readonly PatchAudienceContactRequestDataMode Historical = new(Values.Historical);

    public static readonly PatchAudienceContactRequestDataMode Live = new(Values.Live);

    public PatchAudienceContactRequestDataMode(string value)
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
    public static PatchAudienceContactRequestDataMode FromCustom(string value)
    {
        return new PatchAudienceContactRequestDataMode(value);
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

    public static bool operator ==(PatchAudienceContactRequestDataMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatchAudienceContactRequestDataMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatchAudienceContactRequestDataMode value) =>
        value.Value;

    public static explicit operator PatchAudienceContactRequestDataMode(string value) => new(value);

    internal class PatchAudienceContactRequestDataModeSerializer
        : JsonConverter<PatchAudienceContactRequestDataMode>
    {
        public override PatchAudienceContactRequestDataMode Read(
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
            return new PatchAudienceContactRequestDataMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestDataMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatchAudienceContactRequestDataMode ReadAsPropertyName(
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
            return new PatchAudienceContactRequestDataMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestDataMode value,
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
