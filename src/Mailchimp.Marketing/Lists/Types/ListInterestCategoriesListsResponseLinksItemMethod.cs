using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListInterestCategoriesListsResponseLinksItemMethod.ListInterestCategoriesListsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListInterestCategoriesListsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListInterestCategoriesListsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListInterestCategoriesListsResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListInterestCategoriesListsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListInterestCategoriesListsResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListInterestCategoriesListsResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListInterestCategoriesListsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListInterestCategoriesListsResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListInterestCategoriesListsResponseLinksItemMethod(string value)
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
    public static ListInterestCategoriesListsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListInterestCategoriesListsResponseLinksItemMethod(value);
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
        ListInterestCategoriesListsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListInterestCategoriesListsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListInterestCategoriesListsResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListInterestCategoriesListsResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListInterestCategoriesListsResponseLinksItemMethodSerializer
        : JsonConverter<ListInterestCategoriesListsResponseLinksItemMethod>
    {
        public override ListInterestCategoriesListsResponseLinksItemMethod Read(
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
            return new ListInterestCategoriesListsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListInterestCategoriesListsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListInterestCategoriesListsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListInterestCategoriesListsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListInterestCategoriesListsResponseLinksItemMethod value,
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
