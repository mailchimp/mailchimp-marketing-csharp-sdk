using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListTemplatesRequestContentType.ListTemplatesRequestContentTypeSerializer))]
[Serializable]
public readonly record struct ListTemplatesRequestContentType : IStringEnum
{
    public static readonly ListTemplatesRequestContentType Html = new(Values.Html);

    public static readonly ListTemplatesRequestContentType Template = new(Values.Template);

    public static readonly ListTemplatesRequestContentType Multichannel = new(Values.Multichannel);

    public ListTemplatesRequestContentType(string value)
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
    public static ListTemplatesRequestContentType FromCustom(string value)
    {
        return new ListTemplatesRequestContentType(value);
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

    public static bool operator ==(ListTemplatesRequestContentType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListTemplatesRequestContentType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListTemplatesRequestContentType value) => value.Value;

    public static explicit operator ListTemplatesRequestContentType(string value) => new(value);

    internal class ListTemplatesRequestContentTypeSerializer
        : JsonConverter<ListTemplatesRequestContentType>
    {
        public override ListTemplatesRequestContentType Read(
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
            return new ListTemplatesRequestContentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListTemplatesRequestContentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListTemplatesRequestContentType ReadAsPropertyName(
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
            return new ListTemplatesRequestContentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListTemplatesRequestContentType value,
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
        public const string Html = "html";

        public const string Template = "template";

        public const string Multichannel = "multichannel";
    }
}
