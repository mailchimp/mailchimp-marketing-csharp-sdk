using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(TemplateInstanceLinksItemMethod.TemplateInstanceLinksItemMethodSerializer))]
[Serializable]
public readonly record struct TemplateInstanceLinksItemMethod : IStringEnum
{
    public static readonly TemplateInstanceLinksItemMethod Get = new(Values.Get);

    public static readonly TemplateInstanceLinksItemMethod Post = new(Values.Post);

    public static readonly TemplateInstanceLinksItemMethod Put = new(Values.Put);

    public static readonly TemplateInstanceLinksItemMethod Patch = new(Values.Patch);

    public static readonly TemplateInstanceLinksItemMethod Delete = new(Values.Delete);

    public static readonly TemplateInstanceLinksItemMethod Options = new(Values.Options);

    public static readonly TemplateInstanceLinksItemMethod Head = new(Values.Head);

    public TemplateInstanceLinksItemMethod(string value)
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
    public static TemplateInstanceLinksItemMethod FromCustom(string value)
    {
        return new TemplateInstanceLinksItemMethod(value);
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

    public static bool operator ==(TemplateInstanceLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TemplateInstanceLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TemplateInstanceLinksItemMethod value) => value.Value;

    public static explicit operator TemplateInstanceLinksItemMethod(string value) => new(value);

    internal class TemplateInstanceLinksItemMethodSerializer
        : JsonConverter<TemplateInstanceLinksItemMethod>
    {
        public override TemplateInstanceLinksItemMethod Read(
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
            return new TemplateInstanceLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TemplateInstanceLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TemplateInstanceLinksItemMethod ReadAsPropertyName(
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
            return new TemplateInstanceLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TemplateInstanceLinksItemMethod value,
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
