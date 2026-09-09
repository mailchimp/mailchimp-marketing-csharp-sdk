using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListMembersListsRequestSortField.ListMembersListsRequestSortFieldSerializer))]
[Serializable]
public readonly record struct ListMembersListsRequestSortField : IStringEnum
{
    public static readonly ListMembersListsRequestSortField TimestampOpt = new(Values.TimestampOpt);

    public static readonly ListMembersListsRequestSortField TimestampSignup = new(
        Values.TimestampSignup
    );

    public static readonly ListMembersListsRequestSortField LastChanged = new(Values.LastChanged);

    public ListMembersListsRequestSortField(string value)
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
    public static ListMembersListsRequestSortField FromCustom(string value)
    {
        return new ListMembersListsRequestSortField(value);
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

    public static bool operator ==(ListMembersListsRequestSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMembersListsRequestSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMembersListsRequestSortField value) => value.Value;

    public static explicit operator ListMembersListsRequestSortField(string value) => new(value);

    internal class ListMembersListsRequestSortFieldSerializer
        : JsonConverter<ListMembersListsRequestSortField>
    {
        public override ListMembersListsRequestSortField Read(
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
            return new ListMembersListsRequestSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMembersListsRequestSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMembersListsRequestSortField ReadAsPropertyName(
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
            return new ListMembersListsRequestSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMembersListsRequestSortField value,
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
        public const string TimestampOpt = "timestamp_opt";

        public const string TimestampSignup = "timestamp_signup";

        public const string LastChanged = "last_changed";
    }
}
