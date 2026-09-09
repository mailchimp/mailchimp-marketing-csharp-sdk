using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListsPostLinksItemMethod.ListsPostLinksItemMethodSerializer))]
[Serializable]
public readonly record struct ListsPostLinksItemMethod : IStringEnum
{
    public static readonly ListsPostLinksItemMethod Get = new(Values.Get);

    public static readonly ListsPostLinksItemMethod Post = new(Values.Post);

    public static readonly ListsPostLinksItemMethod Put = new(Values.Put);

    public static readonly ListsPostLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListsPostLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListsPostLinksItemMethod Options = new(Values.Options);

    public static readonly ListsPostLinksItemMethod Head = new(Values.Head);

    public ListsPostLinksItemMethod(string value)
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
    public static ListsPostLinksItemMethod FromCustom(string value)
    {
        return new ListsPostLinksItemMethod(value);
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

    public static bool operator ==(ListsPostLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListsPostLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListsPostLinksItemMethod value) => value.Value;

    public static explicit operator ListsPostLinksItemMethod(string value) => new(value);

    internal class ListsPostLinksItemMethodSerializer : JsonConverter<ListsPostLinksItemMethod>
    {
        public override ListsPostLinksItemMethod Read(
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
            return new ListsPostLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListsPostLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListsPostLinksItemMethod ReadAsPropertyName(
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
            return new ListsPostLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListsPostLinksItemMethod value,
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
