using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListLocationsReportsResponseLinksItemMethod.ListLocationsReportsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListLocationsReportsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListLocationsReportsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListLocationsReportsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListLocationsReportsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListLocationsReportsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListLocationsReportsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListLocationsReportsResponseLinksItemMethod Options = new(
        Values.Options
    );

    public static readonly ListLocationsReportsResponseLinksItemMethod Head = new(Values.Head);

    public ListLocationsReportsResponseLinksItemMethod(string value)
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
    public static ListLocationsReportsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListLocationsReportsResponseLinksItemMethod(value);
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
        ListLocationsReportsResponseLinksItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListLocationsReportsResponseLinksItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListLocationsReportsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListLocationsReportsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListLocationsReportsResponseLinksItemMethodSerializer
        : JsonConverter<ListLocationsReportsResponseLinksItemMethod>
    {
        public override ListLocationsReportsResponseLinksItemMethod Read(
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
            return new ListLocationsReportsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListLocationsReportsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListLocationsReportsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListLocationsReportsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListLocationsReportsResponseLinksItemMethod value,
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
