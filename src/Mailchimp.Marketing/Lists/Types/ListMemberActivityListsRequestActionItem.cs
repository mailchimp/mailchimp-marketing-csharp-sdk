using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMemberActivityListsRequestActionItem.ListMemberActivityListsRequestActionItemSerializer)
)]
[Serializable]
public readonly record struct ListMemberActivityListsRequestActionItem : IStringEnum
{
    public static readonly ListMemberActivityListsRequestActionItem Abuse = new(Values.Abuse);

    public static readonly ListMemberActivityListsRequestActionItem Bounce = new(Values.Bounce);

    public static readonly ListMemberActivityListsRequestActionItem Click = new(Values.Click);

    public static readonly ListMemberActivityListsRequestActionItem Open = new(Values.Open);

    public static readonly ListMemberActivityListsRequestActionItem Sent = new(Values.Sent);

    public static readonly ListMemberActivityListsRequestActionItem Unsub = new(Values.Unsub);

    public static readonly ListMemberActivityListsRequestActionItem Ecomm = new(Values.Ecomm);

    public ListMemberActivityListsRequestActionItem(string value)
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
    public static ListMemberActivityListsRequestActionItem FromCustom(string value)
    {
        return new ListMemberActivityListsRequestActionItem(value);
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
        ListMemberActivityListsRequestActionItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListMemberActivityListsRequestActionItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListMemberActivityListsRequestActionItem value) =>
        value.Value;

    public static explicit operator ListMemberActivityListsRequestActionItem(string value) =>
        new(value);

    internal class ListMemberActivityListsRequestActionItemSerializer
        : JsonConverter<ListMemberActivityListsRequestActionItem>
    {
        public override ListMemberActivityListsRequestActionItem Read(
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
            return new ListMemberActivityListsRequestActionItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMemberActivityListsRequestActionItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMemberActivityListsRequestActionItem ReadAsPropertyName(
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
            return new ListMemberActivityListsRequestActionItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMemberActivityListsRequestActionItem value,
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
        public const string Abuse = "abuse";

        public const string Bounce = "bounce";

        public const string Click = "click";

        public const string Open = "open";

        public const string Sent = "sent";

        public const string Unsub = "unsub";

        public const string Ecomm = "ecomm";
    }
}
