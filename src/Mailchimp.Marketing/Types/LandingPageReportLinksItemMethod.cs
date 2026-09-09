using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(LandingPageReportLinksItemMethod.LandingPageReportLinksItemMethodSerializer))]
[Serializable]
public readonly record struct LandingPageReportLinksItemMethod : IStringEnum
{
    public static readonly LandingPageReportLinksItemMethod Get = new(Values.Get);

    public static readonly LandingPageReportLinksItemMethod Post = new(Values.Post);

    public static readonly LandingPageReportLinksItemMethod Put = new(Values.Put);

    public static readonly LandingPageReportLinksItemMethod Patch = new(Values.Patch);

    public static readonly LandingPageReportLinksItemMethod Delete = new(Values.Delete);

    public static readonly LandingPageReportLinksItemMethod Options = new(Values.Options);

    public static readonly LandingPageReportLinksItemMethod Head = new(Values.Head);

    public LandingPageReportLinksItemMethod(string value)
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
    public static LandingPageReportLinksItemMethod FromCustom(string value)
    {
        return new LandingPageReportLinksItemMethod(value);
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

    public static bool operator ==(LandingPageReportLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LandingPageReportLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LandingPageReportLinksItemMethod value) => value.Value;

    public static explicit operator LandingPageReportLinksItemMethod(string value) => new(value);

    internal class LandingPageReportLinksItemMethodSerializer
        : JsonConverter<LandingPageReportLinksItemMethod>
    {
        public override LandingPageReportLinksItemMethod Read(
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
            return new LandingPageReportLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LandingPageReportLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LandingPageReportLinksItemMethod ReadAsPropertyName(
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
            return new LandingPageReportLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LandingPageReportLinksItemMethod value,
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
