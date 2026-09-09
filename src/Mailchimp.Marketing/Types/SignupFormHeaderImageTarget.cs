using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SignupFormHeaderImageTarget.SignupFormHeaderImageTargetSerializer))]
[Serializable]
public readonly record struct SignupFormHeaderImageTarget : IStringEnum
{
    public static readonly SignupFormHeaderImageTarget Blank = new(Values.Blank);

    public static readonly SignupFormHeaderImageTarget Null = new(Values.Null);

    public SignupFormHeaderImageTarget(string value)
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
    public static SignupFormHeaderImageTarget FromCustom(string value)
    {
        return new SignupFormHeaderImageTarget(value);
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

    public static bool operator ==(SignupFormHeaderImageTarget value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SignupFormHeaderImageTarget value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SignupFormHeaderImageTarget value) => value.Value;

    public static explicit operator SignupFormHeaderImageTarget(string value) => new(value);

    internal class SignupFormHeaderImageTargetSerializer
        : JsonConverter<SignupFormHeaderImageTarget>
    {
        public override SignupFormHeaderImageTarget Read(
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
            return new SignupFormHeaderImageTarget(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SignupFormHeaderImageTarget value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SignupFormHeaderImageTarget ReadAsPropertyName(
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
            return new SignupFormHeaderImageTarget(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SignupFormHeaderImageTarget value,
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
        public const string Blank = "_blank";

        public const string Null = "null";
    }
}
