using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListEcommerceResponseLinksItemMethod.ListEcommerceResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListEcommerceResponseLinksItemMethod : IStringEnum
{
    public static readonly ListEcommerceResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListEcommerceResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListEcommerceResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListEcommerceResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListEcommerceResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListEcommerceResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListEcommerceResponseLinksItemMethod Head = new(Values.Head);

    public ListEcommerceResponseLinksItemMethod(string value)
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
    public static ListEcommerceResponseLinksItemMethod FromCustom(string value)
    {
        return new ListEcommerceResponseLinksItemMethod(value);
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

    public static bool operator ==(ListEcommerceResponseLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListEcommerceResponseLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListEcommerceResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListEcommerceResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListEcommerceResponseLinksItemMethodSerializer
        : JsonConverter<ListEcommerceResponseLinksItemMethod>
    {
        public override ListEcommerceResponseLinksItemMethod Read(
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
            return new ListEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListEcommerceResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListEcommerceResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListEcommerceResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListEcommerceResponseLinksItemMethod value,
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
