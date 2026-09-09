using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMembersListsRequestInterestMatch.ListMembersListsRequestInterestMatchSerializer)
)]
[Serializable]
public readonly record struct ListMembersListsRequestInterestMatch : IStringEnum
{
    public static readonly ListMembersListsRequestInterestMatch Any = new(Values.Any);

    public static readonly ListMembersListsRequestInterestMatch All = new(Values.All);

    public static readonly ListMembersListsRequestInterestMatch None = new(Values.None);

    public ListMembersListsRequestInterestMatch(string value)
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
    public static ListMembersListsRequestInterestMatch FromCustom(string value)
    {
        return new ListMembersListsRequestInterestMatch(value);
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

    public static bool operator ==(ListMembersListsRequestInterestMatch value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListMembersListsRequestInterestMatch value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListMembersListsRequestInterestMatch value) =>
        value.Value;

    public static explicit operator ListMembersListsRequestInterestMatch(string value) =>
        new(value);

    internal class ListMembersListsRequestInterestMatchSerializer
        : JsonConverter<ListMembersListsRequestInterestMatch>
    {
        public override ListMembersListsRequestInterestMatch Read(
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
            return new ListMembersListsRequestInterestMatch(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMembersListsRequestInterestMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMembersListsRequestInterestMatch ReadAsPropertyName(
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
            return new ListMembersListsRequestInterestMatch(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMembersListsRequestInterestMatch value,
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
        public const string Any = "any";

        public const string All = "all";

        public const string None = "none";
    }
}
