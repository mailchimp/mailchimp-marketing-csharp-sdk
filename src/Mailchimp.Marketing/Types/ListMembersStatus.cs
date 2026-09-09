using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListMembersStatus.ListMembersStatusSerializer))]
[Serializable]
public readonly record struct ListMembersStatus : IStringEnum
{
    public static readonly ListMembersStatus Subscribed = new(Values.Subscribed);

    public static readonly ListMembersStatus Unsubscribed = new(Values.Unsubscribed);

    public static readonly ListMembersStatus Cleaned = new(Values.Cleaned);

    public static readonly ListMembersStatus Pending = new(Values.Pending);

    public static readonly ListMembersStatus Transactional = new(Values.Transactional);

    public static readonly ListMembersStatus Archived = new(Values.Archived);

    public ListMembersStatus(string value)
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
    public static ListMembersStatus FromCustom(string value)
    {
        return new ListMembersStatus(value);
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

    public static bool operator ==(ListMembersStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMembersStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMembersStatus value) => value.Value;

    public static explicit operator ListMembersStatus(string value) => new(value);

    internal class ListMembersStatusSerializer : JsonConverter<ListMembersStatus>
    {
        public override ListMembersStatus Read(
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
            return new ListMembersStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMembersStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMembersStatus ReadAsPropertyName(
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
            return new ListMembersStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMembersStatus value,
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
