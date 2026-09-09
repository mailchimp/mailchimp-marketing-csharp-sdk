using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListLandingPagesResponseLinksItemMethod.ListLandingPagesResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListLandingPagesResponseLinksItemMethod : IStringEnum
{
    public static readonly ListLandingPagesResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListLandingPagesResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListLandingPagesResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListLandingPagesResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListLandingPagesResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListLandingPagesResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListLandingPagesResponseLinksItemMethod Head = new(Values.Head);

    public ListLandingPagesResponseLinksItemMethod(string value)
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
    public static ListLandingPagesResponseLinksItemMethod FromCustom(string value)
    {
        return new ListLandingPagesResponseLinksItemMethod(value);
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

    public static bool operator ==(ListLandingPagesResponseLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListLandingPagesResponseLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListLandingPagesResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListLandingPagesResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListLandingPagesResponseLinksItemMethodSerializer
        : JsonConverter<ListLandingPagesResponseLinksItemMethod>
    {
        public override ListLandingPagesResponseLinksItemMethod Read(
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
            return new ListLandingPagesResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListLandingPagesResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListLandingPagesResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListLandingPagesResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListLandingPagesResponseLinksItemMethod value,
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
