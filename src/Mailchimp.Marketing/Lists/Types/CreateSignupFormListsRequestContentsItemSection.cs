using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateSignupFormListsRequestContentsItemSection.CreateSignupFormListsRequestContentsItemSectionSerializer)
)]
[Serializable]
public readonly record struct CreateSignupFormListsRequestContentsItemSection : IStringEnum
{
    public static readonly CreateSignupFormListsRequestContentsItemSection SignupMessage = new(
        Values.SignupMessage
    );

    public static readonly CreateSignupFormListsRequestContentsItemSection UnsubMessage = new(
        Values.UnsubMessage
    );

    public static readonly CreateSignupFormListsRequestContentsItemSection SignupThankYouTitle =
        new(Values.SignupThankYouTitle);

    public CreateSignupFormListsRequestContentsItemSection(string value)
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
    public static CreateSignupFormListsRequestContentsItemSection FromCustom(string value)
    {
        return new CreateSignupFormListsRequestContentsItemSection(value);
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
        CreateSignupFormListsRequestContentsItemSection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateSignupFormListsRequestContentsItemSection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateSignupFormListsRequestContentsItemSection value) =>
        value.Value;

    public static explicit operator CreateSignupFormListsRequestContentsItemSection(string value) =>
        new(value);

    internal class CreateSignupFormListsRequestContentsItemSectionSerializer
        : JsonConverter<CreateSignupFormListsRequestContentsItemSection>
    {
        public override CreateSignupFormListsRequestContentsItemSection Read(
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
            return new CreateSignupFormListsRequestContentsItemSection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestContentsItemSection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateSignupFormListsRequestContentsItemSection ReadAsPropertyName(
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
            return new CreateSignupFormListsRequestContentsItemSection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestContentsItemSection value,
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
