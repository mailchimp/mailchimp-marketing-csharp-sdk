using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SignupFormContentsItemSection.SignupFormContentsItemSectionSerializer))]
[Serializable]
public readonly record struct SignupFormContentsItemSection : IStringEnum
{
    public static readonly SignupFormContentsItemSection SignupMessage = new(Values.SignupMessage);

    public static readonly SignupFormContentsItemSection UnsubMessage = new(Values.UnsubMessage);

    public static readonly SignupFormContentsItemSection SignupThankYouTitle = new(
        Values.SignupThankYouTitle
    );

    public SignupFormContentsItemSection(string value)
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
    public static SignupFormContentsItemSection FromCustom(string value)
    {
        return new SignupFormContentsItemSection(value);
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

    public static bool operator ==(SignupFormContentsItemSection value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SignupFormContentsItemSection value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SignupFormContentsItemSection value) => value.Value;

    public static explicit operator SignupFormContentsItemSection(string value) => new(value);

    internal class SignupFormContentsItemSectionSerializer
        : JsonConverter<SignupFormContentsItemSection>
    {
        public override SignupFormContentsItemSection Read(
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
            return new SignupFormContentsItemSection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SignupFormContentsItemSection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SignupFormContentsItemSection ReadAsPropertyName(
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
            return new SignupFormContentsItemSection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SignupFormContentsItemSection value,
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
        public const string SignupMessage = "signup_message";

        public const string UnsubMessage = "unsub_message";

        public const string SignupThankYouTitle = "signup_thank_you_title";
    }
}
