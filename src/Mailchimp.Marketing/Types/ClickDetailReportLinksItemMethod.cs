using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ClickDetailReportLinksItemMethod.ClickDetailReportLinksItemMethodSerializer))]
[Serializable]
public readonly record struct ClickDetailReportLinksItemMethod : IStringEnum
{
    public static readonly ClickDetailReportLinksItemMethod Get = new(Values.Get);

    public static readonly ClickDetailReportLinksItemMethod Post = new(Values.Post);

    public static readonly ClickDetailReportLinksItemMethod Put = new(Values.Put);

    public static readonly ClickDetailReportLinksItemMethod Patch = new(Values.Patch);

    public static readonly ClickDetailReportLinksItemMethod Delete = new(Values.Delete);

    public static readonly ClickDetailReportLinksItemMethod Options = new(Values.Options);

    public static readonly ClickDetailReportLinksItemMethod Head = new(Values.Head);

    public ClickDetailReportLinksItemMethod(string value)
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
    public static ClickDetailReportLinksItemMethod FromCustom(string value)
    {
        return new ClickDetailReportLinksItemMethod(value);
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

    public static bool operator ==(ClickDetailReportLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClickDetailReportLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClickDetailReportLinksItemMethod value) => value.Value;

    public static explicit operator ClickDetailReportLinksItemMethod(string value) => new(value);

    internal class ClickDetailReportLinksItemMethodSerializer
        : JsonConverter<ClickDetailReportLinksItemMethod>
    {
        public override ClickDetailReportLinksItemMethod Read(
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
            return new ClickDetailReportLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ClickDetailReportLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ClickDetailReportLinksItemMethod ReadAsPropertyName(
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
            return new ClickDetailReportLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ClickDetailReportLinksItemMethod value,
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
