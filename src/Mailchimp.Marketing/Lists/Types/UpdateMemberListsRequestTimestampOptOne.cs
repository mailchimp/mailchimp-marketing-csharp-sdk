using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpdateMemberListsRequestTimestampOptOne.UpdateMemberListsRequestTimestampOptOneSerializer)
)]
[Serializable]
public readonly record struct UpdateMemberListsRequestTimestampOptOne : IStringEnum
{
    public static readonly UpdateMemberListsRequestTimestampOptOne Empty = new(Values.Empty);

    public UpdateMemberListsRequestTimestampOptOne(string value)
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
    public static UpdateMemberListsRequestTimestampOptOne FromCustom(string value)
    {
        return new UpdateMemberListsRequestTimestampOptOne(value);
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

    public static bool operator ==(UpdateMemberListsRequestTimestampOptOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateMemberListsRequestTimestampOptOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateMemberListsRequestTimestampOptOne value) =>
        value.Value;

    public static explicit operator UpdateMemberListsRequestTimestampOptOne(string value) =>
        new(value);

    internal class UpdateMemberListsRequestTimestampOptOneSerializer
        : JsonConverter<UpdateMemberListsRequestTimestampOptOne>
    {
        public override UpdateMemberListsRequestTimestampOptOne Read(
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
            return new UpdateMemberListsRequestTimestampOptOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateMemberListsRequestTimestampOptOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateMemberListsRequestTimestampOptOne ReadAsPropertyName(
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
            return new UpdateMemberListsRequestTimestampOptOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateMemberListsRequestTimestampOptOne value,
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
