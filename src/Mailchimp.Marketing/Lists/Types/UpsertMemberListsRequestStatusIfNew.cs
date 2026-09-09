using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(UpsertMemberListsRequestStatusIfNew.UpsertMemberListsRequestStatusIfNewSerializer)
)]
[Serializable]
public readonly record struct UpsertMemberListsRequestStatusIfNew : IStringEnum
{
    public static readonly UpsertMemberListsRequestStatusIfNew Subscribed = new(Values.Subscribed);

    public static readonly UpsertMemberListsRequestStatusIfNew Unsubscribed = new(
        Values.Unsubscribed
    );

    public static readonly UpsertMemberListsRequestStatusIfNew Cleaned = new(Values.Cleaned);

    public static readonly UpsertMemberListsRequestStatusIfNew Pending = new(Values.Pending);

    public static readonly UpsertMemberListsRequestStatusIfNew Transactional = new(
        Values.Transactional
    );

    public UpsertMemberListsRequestStatusIfNew(string value)
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
    public static UpsertMemberListsRequestStatusIfNew FromCustom(string value)
    {
        return new UpsertMemberListsRequestStatusIfNew(value);
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

    public static bool operator ==(UpsertMemberListsRequestStatusIfNew value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpsertMemberListsRequestStatusIfNew value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpsertMemberListsRequestStatusIfNew value) =>
        value.Value;

    public static explicit operator UpsertMemberListsRequestStatusIfNew(string value) => new(value);

    internal class UpsertMemberListsRequestStatusIfNewSerializer
        : JsonConverter<UpsertMemberListsRequestStatusIfNew>
    {
        public override UpsertMemberListsRequestStatusIfNew Read(
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
            return new UpsertMemberListsRequestStatusIfNew(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpsertMemberListsRequestStatusIfNew value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpsertMemberListsRequestStatusIfNew ReadAsPropertyName(
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
            return new UpsertMemberListsRequestStatusIfNew(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpsertMemberListsRequestStatusIfNew value,
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
