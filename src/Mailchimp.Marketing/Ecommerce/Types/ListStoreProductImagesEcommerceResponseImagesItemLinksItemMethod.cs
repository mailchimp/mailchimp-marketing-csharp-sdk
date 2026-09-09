using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod.ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod
    : IStringEnum
{
    public static readonly ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Get =
        new(Values.Get);

    public static readonly ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Post =
        new(Values.Post);

    public static readonly ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Put =
        new(Values.Put);

    public static readonly ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Patch =
        new(Values.Patch);

    public static readonly ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Delete =
        new(Values.Delete);

    public static readonly ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Options =
        new(Values.Options);

    public static readonly ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Head =
        new(Values.Head);

    public ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod(string value)
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
    public static ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod FromCustom(
        string value
    )
    {
        return new ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod(value);
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
        ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod(
        string value
    ) => new(value);

    internal class ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethodSerializer
        : JsonConverter<ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod>
    {
        public override ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod Read(
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
            return new ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod ReadAsPropertyName(
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
            return new ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListStoreProductImagesEcommerceResponseImagesItemLinksItemMethod value,
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
