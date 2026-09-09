using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListReportingResponseItemMethod.ListReportingResponseItemMethodSerializer))]
[Serializable]
public readonly record struct ListReportingResponseItemMethod : IStringEnum
{
    public static readonly ListReportingResponseItemMethod Get = new(Values.Get);

    public static readonly ListReportingResponseItemMethod Post = new(Values.Post);

    public static readonly ListReportingResponseItemMethod Put = new(Values.Put);

    public static readonly ListReportingResponseItemMethod Patch = new(Values.Patch);

    public static readonly ListReportingResponseItemMethod Delete = new(Values.Delete);

    public static readonly ListReportingResponseItemMethod Options = new(Values.Options);

    public static readonly ListReportingResponseItemMethod Head = new(Values.Head);

    public ListReportingResponseItemMethod(string value)
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
    public static ListReportingResponseItemMethod FromCustom(string value)
    {
        return new ListReportingResponseItemMethod(value);
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

    public static bool operator ==(ListReportingResponseItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListReportingResponseItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListReportingResponseItemMethod value) => value.Value;

    public static explicit operator ListReportingResponseItemMethod(string value) => new(value);

    internal class ListReportingResponseItemMethodSerializer
        : JsonConverter<ListReportingResponseItemMethod>
    {
        public override ListReportingResponseItemMethod Read(
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
            return new ListReportingResponseItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListReportingResponseItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListReportingResponseItemMethod ReadAsPropertyName(
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
            return new ListReportingResponseItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListReportingResponseItemMethod value,
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
