using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SignupFormHeaderImageAlign.SignupFormHeaderImageAlignSerializer))]
[Serializable]
public readonly record struct SignupFormHeaderImageAlign : IStringEnum
{
    public static readonly SignupFormHeaderImageAlign None = new(Values.None);

    public static readonly SignupFormHeaderImageAlign Left = new(Values.Left);

    public static readonly SignupFormHeaderImageAlign Center = new(Values.Center);

    public static readonly SignupFormHeaderImageAlign Right = new(Values.Right);

    public SignupFormHeaderImageAlign(string value)
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
    public static SignupFormHeaderImageAlign FromCustom(string value)
    {
        return new SignupFormHeaderImageAlign(value);
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

    public static bool operator ==(SignupFormHeaderImageAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SignupFormHeaderImageAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SignupFormHeaderImageAlign value) => value.Value;

    public static explicit operator SignupFormHeaderImageAlign(string value) => new(value);

    internal class SignupFormHeaderImageAlignSerializer : JsonConverter<SignupFormHeaderImageAlign>
    {
        public override SignupFormHeaderImageAlign Read(
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
            return new SignupFormHeaderImageAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SignupFormHeaderImageAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SignupFormHeaderImageAlign ReadAsPropertyName(
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
            return new SignupFormHeaderImageAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SignupFormHeaderImageAlign value,
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
        public const string None = "none";

        public const string Left = "left";

        public const string Center = "center";

        public const string Right = "right";
    }
}
