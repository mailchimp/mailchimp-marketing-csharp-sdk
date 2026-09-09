using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListStoreCustomersEcommerceResponseLinksItemMethod.ListStoreCustomersEcommerceResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListStoreCustomersEcommerceResponseLinksItemMethod : IStringEnum
{
    public static readonly ListStoreCustomersEcommerceResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListStoreCustomersEcommerceResponseLinksItemMethod Post = new(
        Values.Post
    );

    public static readonly ListStoreCustomersEcommerceResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListStoreCustomersEcommerceResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListStoreCustomersEcommerceResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListStoreCustomersEcommerceResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListStoreCustomersEcommerceResponseLinksItemMethod Head = new(
        Values.Head
    );

    public ListStoreCustomersEcommerceResponseLinksItemMethod(string value)
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
    public static ListStoreCustomersEcommerceResponseLinksItemMethod FromCustom(string value)
    {
        return new ListStoreCustomersEcommerceResponseLinksItemMethod(value);
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
        ListStoreCustomersEcommerceResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListStoreCustomersEcommerceResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListStoreCustomersEcommerceResponseLinksItemMethod value
    ) => value.Value;

    public static explicit operator ListStoreCustomersEcommerceResponseLinksItemMethod(
        string value
    ) => new(value);

    internal class ListStoreCustomersEcommerceResponseLinksItemMethodSerializer
        : JsonConverter<ListStoreCustomersEcommerceResponseLinksItemMethod>
    {
        public override ListStoreCustomersEcommerceResponseLinksItemMethod Read(
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
            return new ListStoreCustomersEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListStoreCustomersEcommerceResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListStoreCustomersEcommerceResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListStoreCustomersEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListStoreCustomersEcommerceResponseLinksItemMethod value,
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
