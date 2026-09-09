using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListEepurlReportsResponseLinksItemMethod.ListEepurlReportsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListEepurlReportsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListEepurlReportsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListEepurlReportsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListEepurlReportsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListEepurlReportsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListEepurlReportsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListEepurlReportsResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListEepurlReportsResponseLinksItemMethod Head = new(Values.Head);

    public ListEepurlReportsResponseLinksItemMethod(string value)
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
    public static ListEepurlReportsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListEepurlReportsResponseLinksItemMethod(value);
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
        ListEepurlReportsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListEepurlReportsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListEepurlReportsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListEepurlReportsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListEepurlReportsResponseLinksItemMethodSerializer
        : JsonConverter<ListEepurlReportsResponseLinksItemMethod>
    {
        public override ListEepurlReportsResponseLinksItemMethod Read(
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
            return new ListEepurlReportsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListEepurlReportsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListEepurlReportsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListEepurlReportsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListEepurlReportsResponseLinksItemMethod value,
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
