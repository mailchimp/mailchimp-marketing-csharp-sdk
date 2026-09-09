using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateMemberListsRequestTimestampSignupOne.CreateMemberListsRequestTimestampSignupOneSerializer)
)]
[Serializable]
public readonly record struct CreateMemberListsRequestTimestampSignupOne : IStringEnum
{
    public static readonly CreateMemberListsRequestTimestampSignupOne Empty = new(Values.Empty);

    public CreateMemberListsRequestTimestampSignupOne(string value)
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
    public static CreateMemberListsRequestTimestampSignupOne FromCustom(string value)
    {
        return new CreateMemberListsRequestTimestampSignupOne(value);
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
        CreateMemberListsRequestTimestampSignupOne value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateMemberListsRequestTimestampSignupOne value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreateMemberListsRequestTimestampSignupOne value) =>
        value.Value;

    public static explicit operator CreateMemberListsRequestTimestampSignupOne(string value) =>
        new(value);

    internal class CreateMemberListsRequestTimestampSignupOneSerializer
        : JsonConverter<CreateMemberListsRequestTimestampSignupOne>
    {
        public override CreateMemberListsRequestTimestampSignupOne Read(
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
            return new CreateMemberListsRequestTimestampSignupOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateMemberListsRequestTimestampSignupOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateMemberListsRequestTimestampSignupOne ReadAsPropertyName(
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
            return new CreateMemberListsRequestTimestampSignupOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateMemberListsRequestTimestampSignupOne value,
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
        public const string Empty = "";
    }
}
