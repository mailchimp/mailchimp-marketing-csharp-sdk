using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListClickDetailsReportsResponseLinksItemMethod.ListClickDetailsReportsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListClickDetailsReportsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListClickDetailsReportsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListClickDetailsReportsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListClickDetailsReportsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListClickDetailsReportsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListClickDetailsReportsResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListClickDetailsReportsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListClickDetailsReportsResponseLinksItemMethod Head = new(Values.Head);

    public ListClickDetailsReportsResponseLinksItemMethod(string value)
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
    public static ListClickDetailsReportsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListClickDetailsReportsResponseLinksItemMethod(value);
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
        ListClickDetailsReportsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListClickDetailsReportsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListClickDetailsReportsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListClickDetailsReportsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListClickDetailsReportsResponseLinksItemMethodSerializer
        : JsonConverter<ListClickDetailsReportsResponseLinksItemMethod>
    {
        public override ListClickDetailsReportsResponseLinksItemMethod Read(
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
            return new ListClickDetailsReportsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListClickDetailsReportsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListClickDetailsReportsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListClickDetailsReportsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListClickDetailsReportsResponseLinksItemMethod value,
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
