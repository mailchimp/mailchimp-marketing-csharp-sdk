using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SignupFormHeaderImageBorderStyle.SignupFormHeaderImageBorderStyleSerializer))]
[Serializable]
public readonly record struct SignupFormHeaderImageBorderStyle : IStringEnum
{
    public static readonly SignupFormHeaderImageBorderStyle None = new(Values.None);

    public static readonly SignupFormHeaderImageBorderStyle Solid = new(Values.Solid);

    public static readonly SignupFormHeaderImageBorderStyle Dotted = new(Values.Dotted);

    public static readonly SignupFormHeaderImageBorderStyle Dashed = new(Values.Dashed);

    public static readonly SignupFormHeaderImageBorderStyle Double = new(Values.Double);

    public static readonly SignupFormHeaderImageBorderStyle Groove = new(Values.Groove);

    public static readonly SignupFormHeaderImageBorderStyle Outset = new(Values.Outset);

    public static readonly SignupFormHeaderImageBorderStyle Inset = new(Values.Inset);

    public static readonly SignupFormHeaderImageBorderStyle Ridge = new(Values.Ridge);

    public SignupFormHeaderImageBorderStyle(string value)
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
    public static SignupFormHeaderImageBorderStyle FromCustom(string value)
    {
        return new SignupFormHeaderImageBorderStyle(value);
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

    public static bool operator ==(SignupFormHeaderImageBorderStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SignupFormHeaderImageBorderStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SignupFormHeaderImageBorderStyle value) => value.Value;

    public static explicit operator SignupFormHeaderImageBorderStyle(string value) => new(value);

    internal class SignupFormHeaderImageBorderStyleSerializer
        : JsonConverter<SignupFormHeaderImageBorderStyle>
    {
        public override SignupFormHeaderImageBorderStyle Read(
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
            return new SignupFormHeaderImageBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SignupFormHeaderImageBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SignupFormHeaderImageBorderStyle ReadAsPropertyName(
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
            return new SignupFormHeaderImageBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SignupFormHeaderImageBorderStyle value,
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

        public const string Solid = "solid";

        public const string Dotted = "dotted";

        public const string Dashed = "dashed";

        public const string Double = "double";

        public const string Groove = "groove";

        public const string Outset = "outset";

        public const string Inset = "inset";

        public const string Ridge = "ridge";
    }
}
