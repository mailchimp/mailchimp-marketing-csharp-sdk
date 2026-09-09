using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListMemberTagsListsResponseLinksItemMethod.ListMemberTagsListsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListMemberTagsListsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListMemberTagsListsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListMemberTagsListsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListMemberTagsListsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListMemberTagsListsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListMemberTagsListsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListMemberTagsListsResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListMemberTagsListsResponseLinksItemMethod Head = new(Values.Head);

    public ListMemberTagsListsResponseLinksItemMethod(string value)
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
    public static ListMemberTagsListsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListMemberTagsListsResponseLinksItemMethod(value);
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
        ListMemberTagsListsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListMemberTagsListsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListMemberTagsListsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListMemberTagsListsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListMemberTagsListsResponseLinksItemMethodSerializer
        : JsonConverter<ListMemberTagsListsResponseLinksItemMethod>
    {
        public override ListMemberTagsListsResponseLinksItemMethod Read(
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
            return new ListMemberTagsListsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListMemberTagsListsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListMemberTagsListsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListMemberTagsListsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListMemberTagsListsResponseLinksItemMethod value,
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
        public const string Get = "GET";

        public const string Post = "POST";

        public const string Put = "PUT";

        public const string Patch = "PATCH";

        public const string Delete = "DELETE";

        public const string Options = "OPTIONS";

        public const string Head = "HEAD";
    }
}
