using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListActivityListsResponseActivityItemLinksItemMethod.ListActivityListsResponseActivityItemLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListActivityListsResponseActivityItemLinksItemMethod : IStringEnum
{
    public static readonly ListActivityListsResponseActivityItemLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListActivityListsResponseActivityItemLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListActivityListsResponseActivityItemLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListActivityListsResponseActivityItemLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListActivityListsResponseActivityItemLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListActivityListsResponseActivityItemLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListActivityListsResponseActivityItemLinksItemMethod Head = new(
        Values.Head
    );

    public ListActivityListsResponseActivityItemLinksItemMethod(string value)
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
    public static ListActivityListsResponseActivityItemLinksItemMethod FromCustom(string value)
    {
        return new ListActivityListsResponseActivityItemLinksItemMethod(value);
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
        ListActivityListsResponseActivityItemLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListActivityListsResponseActivityItemLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListActivityListsResponseActivityItemLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListActivityListsResponseActivityItemLinksItemMethod(
        string value
    ) => new(value);

    internal class ListActivityListsResponseActivityItemLinksItemMethodSerializer
        : JsonConverter<ListActivityListsResponseActivityItemLinksItemMethod>
    {
        public override ListActivityListsResponseActivityItemLinksItemMethod Read(
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
            return new ListActivityListsResponseActivityItemLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListActivityListsResponseActivityItemLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListActivityListsResponseActivityItemLinksItemMethod ReadAsPropertyName(
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
            return new ListActivityListsResponseActivityItemLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListActivityListsResponseActivityItemLinksItemMethod value,
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
