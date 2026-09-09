using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListAutomationsResponseLinksItemMethod.ListAutomationsResponseLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct ListAutomationsResponseLinksItemMethod : IStringEnum
{
    public static readonly ListAutomationsResponseLinksItemMethod Get = new(Values.Get);

    public static readonly ListAutomationsResponseLinksItemMethod Post = new(Values.Post);

    public static readonly ListAutomationsResponseLinksItemMethod Put = new(Values.Put);

    public static readonly ListAutomationsResponseLinksItemMethod Patch = new(Values.Patch);

    public static readonly ListAutomationsResponseLinksItemMethod Delete = new(Values.Delete);

    public static readonly ListAutomationsResponseLinksItemMethod Options = new(Values.Options);

    public static readonly ListAutomationsResponseLinksItemMethod Head = new(Values.Head);

    public ListAutomationsResponseLinksItemMethod(string value)
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
    public static ListAutomationsResponseLinksItemMethod FromCustom(string value)
    {
        return new ListAutomationsResponseLinksItemMethod(value);
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

    public static bool operator ==(ListAutomationsResponseLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListAutomationsResponseLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListAutomationsResponseLinksItemMethod value) =>
        value.Value;

    public static explicit operator ListAutomationsResponseLinksItemMethod(string value) =>
        new(value);

    internal class ListAutomationsResponseLinksItemMethodSerializer
        : JsonConverter<ListAutomationsResponseLinksItemMethod>
    {
        public override ListAutomationsResponseLinksItemMethod Read(
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
            return new ListAutomationsResponseLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAutomationsResponseLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAutomationsResponseLinksItemMethod ReadAsPropertyName(
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
            return new ListAutomationsResponseLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAutomationsResponseLinksItemMethod value,
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
