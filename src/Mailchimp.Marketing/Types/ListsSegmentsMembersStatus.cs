using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListsSegmentsMembersStatus.ListsSegmentsMembersStatusSerializer))]
[Serializable]
public readonly record struct ListsSegmentsMembersStatus : IStringEnum
{
    public static readonly ListsSegmentsMembersStatus Subscribed = new(Values.Subscribed);

    public static readonly ListsSegmentsMembersStatus Unsubscribed = new(Values.Unsubscribed);

    public static readonly ListsSegmentsMembersStatus Cleaned = new(Values.Cleaned);

    public static readonly ListsSegmentsMembersStatus Pending = new(Values.Pending);

    public static readonly ListsSegmentsMembersStatus Transactional = new(Values.Transactional);

    public ListsSegmentsMembersStatus(string value)
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
    public static ListsSegmentsMembersStatus FromCustom(string value)
    {
        return new ListsSegmentsMembersStatus(value);
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

    public static bool operator ==(ListsSegmentsMembersStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListsSegmentsMembersStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListsSegmentsMembersStatus value) => value.Value;

    public static explicit operator ListsSegmentsMembersStatus(string value) => new(value);

    internal class ListsSegmentsMembersStatusSerializer : JsonConverter<ListsSegmentsMembersStatus>
    {
        public override ListsSegmentsMembersStatus Read(
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
            return new ListsSegmentsMembersStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListsSegmentsMembersStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListsSegmentsMembersStatus ReadAsPropertyName(
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
            return new ListsSegmentsMembersStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListsSegmentsMembersStatus value,
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
