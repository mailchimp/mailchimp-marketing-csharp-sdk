using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListStoreCartLinesEcommerceResponseLinksItemMethod.ListStoreCartLinesEcommerceResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListStoreCartLinesEcommerceResponseLinksItemMethod : IStringEnum
{
    public static readonly ListStoreCartLinesEcommerceResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListStoreCartLinesEcommerceResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListStoreCartLinesEcommerceResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListStoreCartLinesEcommerceResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListStoreCartLinesEcommerceResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListStoreCartLinesEcommerceResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListStoreCartLinesEcommerceResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListStoreCartLinesEcommerceResponseLinksItemMethod(string value)
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
    public static ListStoreCartLinesEcommerceResponseLinksItemMethod FromCustom(string value)
    {
        return new ListStoreCartLinesEcommerceResponseLinksItemMethod(value);
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
        ListStoreCartLinesEcommerceResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListStoreCartLinesEcommerceResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListStoreCartLinesEcommerceResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListStoreCartLinesEcommerceResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListStoreCartLinesEcommerceResponseLinksItemMethodSerializer
        : JsonConverter<ListStoreCartLinesEcommerceResponseLinksItemMethod>
    {
        public override ListStoreCartLinesEcommerceResponseLinksItemMethod Read(
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
            return new ListStoreCartLinesEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListStoreCartLinesEcommerceResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListStoreCartLinesEcommerceResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListStoreCartLinesEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListStoreCartLinesEcommerceResponseLinksItemMethod value,
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
