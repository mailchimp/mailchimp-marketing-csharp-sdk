using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(UpsertMemberListsRequestStatus.UpsertMemberListsRequestStatusSerializer))]
[Serializable]
public readonly record struct UpsertMemberListsRequestStatus : IStringEnum
{
    public static readonly UpsertMemberListsRequestStatus Subscribed = new(Values.Subscribed);

    public static readonly UpsertMemberListsRequestStatus Unsubscribed = new(Values.Unsubscribed);

    public static readonly UpsertMemberListsRequestStatus Cleaned = new(Values.Cleaned);

    public static readonly UpsertMemberListsRequestStatus Pending = new(Values.Pending);

    public static readonly UpsertMemberListsRequestStatus Transactional = new(Values.Transactional);

    public UpsertMemberListsRequestStatus(string value)
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
    public static UpsertMemberListsRequestStatus FromCustom(string value)
    {
        return new UpsertMemberListsRequestStatus(value);
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

    public static bool operator ==(UpsertMemberListsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpsertMemberListsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpsertMemberListsRequestStatus value) => value.Value;

    public static explicit operator UpsertMemberListsRequestStatus(string value) => new(value);

    internal class UpsertMemberListsRequestStatusSerializer
        : JsonConverter<UpsertMemberListsRequestStatus>
    {
        public override UpsertMemberListsRequestStatus Read(
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
            return new UpsertMemberListsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpsertMemberListsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpsertMemberListsRequestStatus ReadAsPropertyName(
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
            return new UpsertMemberListsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpsertMemberListsRequestStatus value,
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
        public const string Subscribed = "subscribed";

        public const string Unsubscribed = "unsubscribed";

        public const string Cleaned = "cleaned";

        public const string Pending = "pending";

        public const string Transactional = "transactional";
    }
}
