using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateMemberListsRequestTimestampOptOne.CreateMemberListsRequestTimestampOptOneSerializer)
)]
[Serializable]
public readonly record struct CreateMemberListsRequestTimestampOptOne : IStringEnum
{
    public static readonly CreateMemberListsRequestTimestampOptOne Empty = new(Values.Empty);

    public CreateMemberListsRequestTimestampOptOne(string value)
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
    public static CreateMemberListsRequestTimestampOptOne FromCustom(string value)
    {
        return new CreateMemberListsRequestTimestampOptOne(value);
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

    public static bool operator ==(CreateMemberListsRequestTimestampOptOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateMemberListsRequestTimestampOptOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateMemberListsRequestTimestampOptOne value) =>
        value.Value;

    public static explicit operator CreateMemberListsRequestTimestampOptOne(string value) =>
        new(value);

    internal class CreateMemberListsRequestTimestampOptOneSerializer
        : JsonConverter<CreateMemberListsRequestTimestampOptOne>
    {
        public override CreateMemberListsRequestTimestampOptOne Read(
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
            return new CreateMemberListsRequestTimestampOptOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateMemberListsRequestTimestampOptOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateMemberListsRequestTimestampOptOne ReadAsPropertyName(
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
            return new CreateMemberListsRequestTimestampOptOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateMemberListsRequestTimestampOptOne value,
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
