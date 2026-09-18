using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(PatchAudienceContactRequestMergeFieldValidationMode.PatchAudienceContactRequestMergeFieldValidationModeSerializer)
)]
[Serializable]
public readonly record struct PatchAudienceContactRequestMergeFieldValidationMode : IStringEnum
{
    public static readonly PatchAudienceContactRequestMergeFieldValidationMode IgnoreRequiredChecks =
        new(Values.IgnoreRequiredChecks);

    public static readonly PatchAudienceContactRequestMergeFieldValidationMode Strict = new(
        Values.Strict
    );

    public PatchAudienceContactRequestMergeFieldValidationMode(string value)
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
    public static PatchAudienceContactRequestMergeFieldValidationMode FromCustom(string value)
    {
        return new PatchAudienceContactRequestMergeFieldValidationMode(value);
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
        PatchAudienceContactRequestMergeFieldValidationMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PatchAudienceContactRequestMergeFieldValidationMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PatchAudienceContactRequestMergeFieldValidationMode value
    ) => value.Value;

    public static explicit operator PatchAudienceContactRequestMergeFieldValidationMode(
        string value
    ) => new(value);

    internal class PatchAudienceContactRequestMergeFieldValidationModeSerializer
        : JsonConverter<PatchAudienceContactRequestMergeFieldValidationMode>
    {
        public override PatchAudienceContactRequestMergeFieldValidationMode Read(
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
            return new PatchAudienceContactRequestMergeFieldValidationMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestMergeFieldValidationMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatchAudienceContactRequestMergeFieldValidationMode ReadAsPropertyName(
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
            return new PatchAudienceContactRequestMergeFieldValidationMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatchAudienceContactRequestMergeFieldValidationMode value,
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
        public const string IgnoreRequiredChecks = "ignore_required_checks";

        public const string Strict = "strict";
    }
}
