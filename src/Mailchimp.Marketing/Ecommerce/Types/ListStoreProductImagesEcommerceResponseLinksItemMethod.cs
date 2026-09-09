using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListStoreProductImagesEcommerceResponseLinksItemMethod.ListStoreProductImagesEcommerceResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListStoreProductImagesEcommerceResponseLinksItemMethod : IStringEnum
{
    public static readonly ListStoreProductImagesEcommerceResponseLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListStoreProductImagesEcommerceResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListStoreProductImagesEcommerceResponseLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListStoreProductImagesEcommerceResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListStoreProductImagesEcommerceResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListStoreProductImagesEcommerceResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListStoreProductImagesEcommerceResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListStoreProductImagesEcommerceResponseLinksItemMethod(string value)
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
    public static ListStoreProductImagesEcommerceResponseLinksItemMethod FromCustom(string value)
    {
        return new ListStoreProductImagesEcommerceResponseLinksItemMethod(value);
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
        ListStoreProductImagesEcommerceResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListStoreProductImagesEcommerceResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListStoreProductImagesEcommerceResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListStoreProductImagesEcommerceResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListStoreProductImagesEcommerceResponseLinksItemMethodSerializer
        : JsonConverter<ListStoreProductImagesEcommerceResponseLinksItemMethod>
    {
        public override ListStoreProductImagesEcommerceResponseLinksItemMethod Read(
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
            return new ListStoreProductImagesEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListStoreProductImagesEcommerceResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListStoreProductImagesEcommerceResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListStoreProductImagesEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListStoreProductImagesEcommerceResponseLinksItemMethod value,
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
