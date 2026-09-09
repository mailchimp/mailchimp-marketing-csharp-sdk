using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListConnectedSitesResponseLinksItemMethod.ListConnectedSitesResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListConnectedSitesResponseLinksItemMethod : IStringEnum
{
    public static readonly ListConnectedSitesResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListConnectedSitesResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListConnectedSitesResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListConnectedSitesResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListConnectedSitesResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListConnectedSitesResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListConnectedSitesResponseLinksItemMethod Head = new(Values.Head);

    public ListConnectedSitesResponseLinksItemMethod(string value)
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
    public static ListConnectedSitesResponseLinksItemMethod FromCustom(string value)
    {
        return new ListConnectedSitesResponseLinksItemMethod(value);
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
        ListConnectedSitesResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListConnectedSitesResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListConnectedSitesResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListConnectedSitesResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListConnectedSitesResponseLinksItemMethodSerializer
        : JsonConverter<ListConnectedSitesResponseLinksItemMethod>
    {
        public override ListConnectedSitesResponseLinksItemMethod Read(
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
            return new ListConnectedSitesResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListConnectedSitesResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListConnectedSitesResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListConnectedSitesResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListConnectedSitesResponseLinksItemMethod value,
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
