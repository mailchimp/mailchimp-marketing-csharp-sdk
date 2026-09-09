using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListStoreProductVariantsEcommerceResponseLinksItemMethod.ListStoreProductVariantsEcommerceResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListStoreProductVariantsEcommerceResponseLinksItemMethod : IStringEnum
{
    public static readonly ListStoreProductVariantsEcommerceResponseLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListStoreProductVariantsEcommerceResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListStoreProductVariantsEcommerceResponseLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListStoreProductVariantsEcommerceResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListStoreProductVariantsEcommerceResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListStoreProductVariantsEcommerceResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListStoreProductVariantsEcommerceResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListStoreProductVariantsEcommerceResponseLinksItemMethod(string value)
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
    public static ListStoreProductVariantsEcommerceResponseLinksItemMethod FromCustom(string value)
    {
        return new ListStoreProductVariantsEcommerceResponseLinksItemMethod(value);
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
        ListStoreProductVariantsEcommerceResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListStoreProductVariantsEcommerceResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListStoreProductVariantsEcommerceResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListStoreProductVariantsEcommerceResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListStoreProductVariantsEcommerceResponseLinksItemMethodSerializer
        : JsonConverter<ListStoreProductVariantsEcommerceResponseLinksItemMethod>
    {
        public override ListStoreProductVariantsEcommerceResponseLinksItemMethod Read(
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
            return new ListStoreProductVariantsEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListStoreProductVariantsEcommerceResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListStoreProductVariantsEcommerceResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListStoreProductVariantsEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListStoreProductVariantsEcommerceResponseLinksItemMethod value,
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
