using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(LandingPageLinksItemMethod.LandingPageLinksItemMethodSerializer))]
[Serializable]
public readonly record struct LandingPageLinksItemMethod : IStringEnum
{
    public static readonly LandingPageLinksItemMethod Get = new(Values.Get);

    public static readonly LandingPageLinksItemMethod Post = new(Values.Post);

    public static readonly LandingPageLinksItemMethod Put = new(Values.Put);

    public static readonly LandingPageLinksItemMethod Patch = new(Values.Patch);

    public static readonly LandingPageLinksItemMethod Delete = new(Values.Delete);

    public static readonly LandingPageLinksItemMethod Options = new(Values.Options);

    public static readonly LandingPageLinksItemMethod Head = new(Values.Head);

    public LandingPageLinksItemMethod(string value)
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
    public static LandingPageLinksItemMethod FromCustom(string value)
    {
        return new LandingPageLinksItemMethod(value);
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

    public static bool operator ==(LandingPageLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LandingPageLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LandingPageLinksItemMethod value) => value.Value;

    public static explicit operator LandingPageLinksItemMethod(string value) => new(value);

    internal class LandingPageLinksItemMethodSerializer : JsonConverter<LandingPageLinksItemMethod>
    {
        public override LandingPageLinksItemMethod Read(
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
            return new LandingPageLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LandingPageLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LandingPageLinksItemMethod ReadAsPropertyName(
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
            return new LandingPageLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LandingPageLinksItemMethod value,
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
