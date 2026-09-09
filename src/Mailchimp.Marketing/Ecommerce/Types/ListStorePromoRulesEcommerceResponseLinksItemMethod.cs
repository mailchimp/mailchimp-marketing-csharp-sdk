using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListStorePromoRulesEcommerceResponseLinksItemMethod.ListStorePromoRulesEcommerceResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListStorePromoRulesEcommerceResponseLinksItemMethod : IStringEnum
{
    public static readonly ListStorePromoRulesEcommerceResponseLinksItemMethod Get = new(
        Values.Get
    );

    public static readonly ListStorePromoRulesEcommerceResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListStorePromoRulesEcommerceResponseLinksItemMethod Put = new(
        Values.Put
    );

    public static readonly ListStorePromoRulesEcommerceResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListStorePromoRulesEcommerceResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListStorePromoRulesEcommerceResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListStorePromoRulesEcommerceResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListStorePromoRulesEcommerceResponseLinksItemMethod(string value)
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
    public static ListStorePromoRulesEcommerceResponseLinksItemMethod FromCustom(string value)
    {
        return new ListStorePromoRulesEcommerceResponseLinksItemMethod(value);
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
        ListStorePromoRulesEcommerceResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListStorePromoRulesEcommerceResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListStorePromoRulesEcommerceResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListStorePromoRulesEcommerceResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListStorePromoRulesEcommerceResponseLinksItemMethodSerializer
        : JsonConverter<ListStorePromoRulesEcommerceResponseLinksItemMethod>
    {
        public override ListStorePromoRulesEcommerceResponseLinksItemMethod Read(
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
            return new ListStorePromoRulesEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListStorePromoRulesEcommerceResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListStorePromoRulesEcommerceResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListStorePromoRulesEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListStorePromoRulesEcommerceResponseLinksItemMethod value,
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
