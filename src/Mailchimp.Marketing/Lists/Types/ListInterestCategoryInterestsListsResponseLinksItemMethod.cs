using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListInterestCategoryInterestsListsResponseLinksItemMethod.ListInterestCategoryInterestsListsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListInterestCategoryInterestsListsResponseLinksItemMethod
    : IStringEnum
{
    public static readonly ListInterestCategoryInterestsListsResponseLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListInterestCategoryInterestsListsResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListInterestCategoryInterestsListsResponseLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListInterestCategoryInterestsListsResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListInterestCategoryInterestsListsResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListInterestCategoryInterestsListsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListInterestCategoryInterestsListsResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListInterestCategoryInterestsListsResponseLinksItemMethod(string value)
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
    public static ListInterestCategoryInterestsListsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListInterestCategoryInterestsListsResponseLinksItemMethod(value);
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
        ListInterestCategoryInterestsListsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListInterestCategoryInterestsListsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListInterestCategoryInterestsListsResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListInterestCategoryInterestsListsResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListInterestCategoryInterestsListsResponseLinksItemMethodSerializer
        : JsonConverter<ListInterestCategoryInterestsListsResponseLinksItemMethod>
    {
        public override ListInterestCategoryInterestsListsResponseLinksItemMethod Read(
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
            return new ListInterestCategoryInterestsListsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListInterestCategoryInterestsListsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListInterestCategoryInterestsListsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListInterestCategoryInterestsListsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListInterestCategoryInterestsListsResponseLinksItemMethod value,
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
