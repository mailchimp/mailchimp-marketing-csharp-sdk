using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListUnsubscribedReportsResponseLinksItemMethod.ListUnsubscribedReportsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListUnsubscribedReportsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListUnsubscribedReportsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListUnsubscribedReportsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListUnsubscribedReportsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListUnsubscribedReportsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListUnsubscribedReportsResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListUnsubscribedReportsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListUnsubscribedReportsResponseLinksItemMethod Head = new(Values.Head);

    public ListUnsubscribedReportsResponseLinksItemMethod(string value)
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
    public static ListUnsubscribedReportsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListUnsubscribedReportsResponseLinksItemMethod(value);
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
        ListUnsubscribedReportsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListUnsubscribedReportsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListUnsubscribedReportsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListUnsubscribedReportsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListUnsubscribedReportsResponseLinksItemMethodSerializer
        : JsonConverter<ListUnsubscribedReportsResponseLinksItemMethod>
    {
        public override ListUnsubscribedReportsResponseLinksItemMethod Read(
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
            return new ListUnsubscribedReportsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListUnsubscribedReportsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListUnsubscribedReportsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListUnsubscribedReportsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListUnsubscribedReportsResponseLinksItemMethod value,
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
