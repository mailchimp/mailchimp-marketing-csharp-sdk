using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CreateLandingPagesRequestType.CreateLandingPagesRequestTypeSerializer))]
[Serializable]
public readonly record struct CreateLandingPagesRequestType : IStringEnum
{
    public static readonly CreateLandingPagesRequestType Signup = new(Values.Signup);

    public static readonly CreateLandingPagesRequestType Product = new(Values.Product);

    public CreateLandingPagesRequestType(string value)
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
    public static CreateLandingPagesRequestType FromCustom(string value)
    {
        return new CreateLandingPagesRequestType(value);
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

    public static bool operator ==(CreateLandingPagesRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateLandingPagesRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateLandingPagesRequestType value) => value.Value;

    public static explicit operator CreateLandingPagesRequestType(string value) => new(value);

    internal class CreateLandingPagesRequestTypeSerializer
        : JsonConverter<CreateLandingPagesRequestType>
    {
        public override CreateLandingPagesRequestType Read(
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
            return new CreateLandingPagesRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateLandingPagesRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateLandingPagesRequestType ReadAsPropertyName(
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
            return new CreateLandingPagesRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateLandingPagesRequestType value,
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

        public const string Product = "product";
    }
}
