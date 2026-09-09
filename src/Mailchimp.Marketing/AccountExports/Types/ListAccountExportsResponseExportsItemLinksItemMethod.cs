using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListAccountExportsResponseExportsItemLinksItemMethod.ListAccountExportsResponseExportsItemLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListAccountExportsResponseExportsItemLinksItemMethod : IStringEnum
{
    public static readonly ListAccountExportsResponseExportsItemLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListAccountExportsResponseExportsItemLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListAccountExportsResponseExportsItemLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListAccountExportsResponseExportsItemLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListAccountExportsResponseExportsItemLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListAccountExportsResponseExportsItemLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListAccountExportsResponseExportsItemLinksItemMethod Head = new(
        Values.Head
    );

    public ListAccountExportsResponseExportsItemLinksItemMethod(string value)
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
    public static ListAccountExportsResponseExportsItemLinksItemMethod FromCustom(string value)
    {
        return new ListAccountExportsResponseExportsItemLinksItemMethod(value);
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
        ListAccountExportsResponseExportsItemLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAccountExportsResponseExportsItemLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListAccountExportsResponseExportsItemLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListAccountExportsResponseExportsItemLinksItemMethod(
        string value
    ) => new(value);

    internal class ListAccountExportsResponseExportsItemLinksItemMethodSerializer
        : JsonConverter<ListAccountExportsResponseExportsItemLinksItemMethod>
    {
        public override ListAccountExportsResponseExportsItemLinksItemMethod Read(
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
            return new ListAccountExportsResponseExportsItemLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAccountExportsResponseExportsItemLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAccountExportsResponseExportsItemLinksItemMethod ReadAsPropertyName(
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
            return new ListAccountExportsResponseExportsItemLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAccountExportsResponseExportsItemLinksItemMethod value,
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
