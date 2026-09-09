using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListContentLandingPagesResponseLinksItemMethod.ListContentLandingPagesResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListContentLandingPagesResponseLinksItemMethod : IStringEnum
{
    public static readonly ListContentLandingPagesResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListContentLandingPagesResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListContentLandingPagesResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListContentLandingPagesResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListContentLandingPagesResponseLinksItemMethod Delete = new(
        Values.Delete
    );

    public static readonly ListContentLandingPagesResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListContentLandingPagesResponseLinksItemMethod Head = new(Values.Head);

    public ListContentLandingPagesResponseLinksItemMethod(string value)
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
    public static ListContentLandingPagesResponseLinksItemMethod FromCustom(string value)
    {
        return new ListContentLandingPagesResponseLinksItemMethod(value);
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
        ListContentLandingPagesResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListContentLandingPagesResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListContentLandingPagesResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListContentLandingPagesResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListContentLandingPagesResponseLinksItemMethodSerializer
        : JsonConverter<ListContentLandingPagesResponseLinksItemMethod>
    {
        public override ListContentLandingPagesResponseLinksItemMethod Read(
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
            return new ListContentLandingPagesResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListContentLandingPagesResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListContentLandingPagesResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListContentLandingPagesResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListContentLandingPagesResponseLinksItemMethod value,
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
