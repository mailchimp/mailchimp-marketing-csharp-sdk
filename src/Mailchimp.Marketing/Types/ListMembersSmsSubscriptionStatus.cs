using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListMembersSmsSubscriptionStatus.ListMembersSmsSubscriptionStatusSerializer))]
[Serializable]
public readonly record struct ListMembersSmsSubscriptionStatus : IStringEnum
{
    public static readonly ListMembersSmsSubscriptionStatus Subscribed = new(Values.Subscribed);

    public static readonly ListMembersSmsSubscriptionStatus Unsubscribed = new(Values.Unsubscribed);

    public static readonly ListMembersSmsSubscriptionStatus Nonsubscribed = new(
        Values.Nonsubscribed
    );

    public static readonly ListMembersSmsSubscriptionStatus Pending = new(Values.Pending);

    public ListMembersSmsSubscriptionStatus(string value)
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
    public static ListMembersSmsSubscriptionStatus FromCustom(string value)
    {
        return new ListMembersSmsSubscriptionStatus(value);
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

    public static bool operator ==(ListMembersSmsSubscriptionStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMembersSmsSubscriptionStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMembersSmsSubscriptionStatus value) => value.Value;

    public static explicit operator ListMembersSmsSubscriptionStatus(string value) => new(value);

    internal class ListMembersSmsSubscriptionStatusSerializer
        : JsonConverter<ListMembersSmsSubscriptionStatus>
    {
        public override ListMembersSmsSubscriptionStatus Read(
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
            return new ListMembersSmsSubscriptionStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMembersSmsSubscriptionStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMembersSmsSubscriptionStatus ReadAsPropertyName(
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
            return new ListMembersSmsSubscriptionStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMembersSmsSubscriptionStatus value,
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

        public const string Nonsubscribed = "nonsubscribed";

        public const string Pending = "pending";
    }
}
