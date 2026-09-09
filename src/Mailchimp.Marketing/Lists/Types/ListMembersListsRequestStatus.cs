using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListMembersListsRequestStatus.ListMembersListsRequestStatusSerializer))]
[Serializable]
public readonly record struct ListMembersListsRequestStatus : IStringEnum
{
    public static readonly ListMembersListsRequestStatus Subscribed = new(Values.Subscribed);

    public static readonly ListMembersListsRequestStatus Unsubscribed = new(Values.Unsubscribed);

    public static readonly ListMembersListsRequestStatus Cleaned = new(Values.Cleaned);

    public static readonly ListMembersListsRequestStatus Pending = new(Values.Pending);

    public static readonly ListMembersListsRequestStatus Transactional = new(Values.Transactional);

    public static readonly ListMembersListsRequestStatus Archived = new(Values.Archived);

    public ListMembersListsRequestStatus(string value)
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
    public static ListMembersListsRequestStatus FromCustom(string value)
    {
        return new ListMembersListsRequestStatus(value);
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

    public static bool operator ==(ListMembersListsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMembersListsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMembersListsRequestStatus value) => value.Value;

    public static explicit operator ListMembersListsRequestStatus(string value) => new(value);

    internal class ListMembersListsRequestStatusSerializer
        : JsonConverter<ListMembersListsRequestStatus>
    {
        public override ListMembersListsRequestStatus Read(
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
            return new ListMembersListsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMembersListsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMembersListsRequestStatus ReadAsPropertyName(
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
            return new ListMembersListsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMembersListsRequestStatus value,
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

        public const string Archived = "archived";
    }
}
