using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateSignupFormListsRequestHeaderImageAlign.CreateSignupFormListsRequestHeaderImageAlignSerializer)
)]
[Serializable]
public readonly record struct CreateSignupFormListsRequestHeaderImageAlign : IStringEnum
{
    public static readonly CreateSignupFormListsRequestHeaderImageAlign None = new(Values.None);

    public static readonly CreateSignupFormListsRequestHeaderImageAlign Left = new(Values.Left);

    public static readonly CreateSignupFormListsRequestHeaderImageAlign Center = new(Values.Center);

    public static readonly CreateSignupFormListsRequestHeaderImageAlign Right = new(Values.Right);

    public CreateSignupFormListsRequestHeaderImageAlign(string value)
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
    public static CreateSignupFormListsRequestHeaderImageAlign FromCustom(string value)
    {
        return new CreateSignupFormListsRequestHeaderImageAlign(value);
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
        CreateSignupFormListsRequestHeaderImageAlign value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateSignupFormListsRequestHeaderImageAlign value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateSignupFormListsRequestHeaderImageAlign value) =>
        value.Value;

    public static explicit operator CreateSignupFormListsRequestHeaderImageAlign(string value) =>
        new(value);

    internal class CreateSignupFormListsRequestHeaderImageAlignSerializer
        : JsonConverter<CreateSignupFormListsRequestHeaderImageAlign>
    {
        public override CreateSignupFormListsRequestHeaderImageAlign Read(
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
            return new CreateSignupFormListsRequestHeaderImageAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestHeaderImageAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateSignupFormListsRequestHeaderImageAlign ReadAsPropertyName(
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
            return new CreateSignupFormListsRequestHeaderImageAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateSignupFormListsRequestHeaderImageAlign value,
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
