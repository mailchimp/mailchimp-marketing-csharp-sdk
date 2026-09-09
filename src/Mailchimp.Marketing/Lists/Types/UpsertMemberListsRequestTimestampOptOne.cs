using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpsertMemberListsRequestTimestampOptOne.UpsertMemberListsRequestTimestampOptOneSerializer)
)]
[Serializable]
public readonly record struct UpsertMemberListsRequestTimestampOptOne : IStringEnum
{
    public static readonly UpsertMemberListsRequestTimestampOptOne Empty = new(Values.Empty);

    public UpsertMemberListsRequestTimestampOptOne(string value)
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
    public static UpsertMemberListsRequestTimestampOptOne FromCustom(string value)
    {
        return new UpsertMemberListsRequestTimestampOptOne(value);
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

    public static bool operator ==(UpsertMemberListsRequestTimestampOptOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpsertMemberListsRequestTimestampOptOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpsertMemberListsRequestTimestampOptOne value) =>
        value.Value;

    public static explicit operator UpsertMemberListsRequestTimestampOptOne(string value) =>
        new(value);

    internal class UpsertMemberListsRequestTimestampOptOneSerializer
        : JsonConverter<UpsertMemberListsRequestTimestampOptOne>
    {
        public override UpsertMemberListsRequestTimestampOptOne Read(
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
            return new UpsertMemberListsRequestTimestampOptOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpsertMemberListsRequestTimestampOptOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpsertMemberListsRequestTimestampOptOne ReadAsPropertyName(
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
            return new UpsertMemberListsRequestTimestampOptOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpsertMemberListsRequestTimestampOptOne value,
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
