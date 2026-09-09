using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListEmailActivityReportsResponseLinksItemMethod.ListEmailActivityReportsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListEmailActivityReportsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListEmailActivityReportsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListEmailActivityReportsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListEmailActivityReportsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListEmailActivityReportsResponseLinksItemMethod Patch = new(
        Values.Patch
    );

    public static readonly ListEmailActivityReportsResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListEmailActivityReportsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListEmailActivityReportsResponseLinksItemMethod Head = new(Values.Head);

    public ListEmailActivityReportsResponseLinksItemMethod(string value)
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
    public static ListEmailActivityReportsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListEmailActivityReportsResponseLinksItemMethod(value);
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
        ListEmailActivityReportsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListEmailActivityReportsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListEmailActivityReportsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListEmailActivityReportsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListEmailActivityReportsResponseLinksItemMethodSerializer
        : JsonConverter<ListEmailActivityReportsResponseLinksItemMethod>
    {
        public override ListEmailActivityReportsResponseLinksItemMethod Read(
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
            return new ListEmailActivityReportsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListEmailActivityReportsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListEmailActivityReportsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListEmailActivityReportsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListEmailActivityReportsResponseLinksItemMethod value,
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
