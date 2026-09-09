using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListAbuseReportsListsResponseLinksItemMethod.ListAbuseReportsListsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListAbuseReportsListsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListAbuseReportsListsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListAbuseReportsListsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListAbuseReportsListsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListAbuseReportsListsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListAbuseReportsListsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListAbuseReportsListsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListAbuseReportsListsResponseLinksItemMethod Head = new(Values.Head);

    public ListAbuseReportsListsResponseLinksItemMethod(string value)
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
    public static ListAbuseReportsListsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListAbuseReportsListsResponseLinksItemMethod(value);
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
        ListAbuseReportsListsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAbuseReportsListsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListAbuseReportsListsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListAbuseReportsListsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListAbuseReportsListsResponseLinksItemMethodSerializer
        : JsonConverter<ListAbuseReportsListsResponseLinksItemMethod>
    {
        public override ListAbuseReportsListsResponseLinksItemMethod Read(
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
            return new ListAbuseReportsListsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAbuseReportsListsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAbuseReportsListsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListAbuseReportsListsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAbuseReportsListsResponseLinksItemMethod value,
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
