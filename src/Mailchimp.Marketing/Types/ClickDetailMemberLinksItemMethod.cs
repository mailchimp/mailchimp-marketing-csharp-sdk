using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ClickDetailMemberLinksItemMethod.ClickDetailMemberLinksItemMethodSerializer))]
[Serializable]
public readonly record struct ClickDetailMemberLinksItemMethod : IStringEnum
{
    public static readonly ClickDetailMemberLinksItemMethod Get = new(Values.Get);

    public static readonly ClickDetailMemberLinksItemMethod Post = new(Values.Post);

    public static readonly ClickDetailMemberLinksItemMethod Put = new(Values.Put);

    public static readonly ClickDetailMemberLinksItemMethod Patch = new(Values.Patch);

    public static readonly ClickDetailMemberLinksItemMethod Delete = new(Values.Delete);

    public static readonly ClickDetailMemberLinksItemMethod Options = new(Values.Options);

    public static readonly ClickDetailMemberLinksItemMethod Head = new(Values.Head);

    public ClickDetailMemberLinksItemMethod(string value)
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
    public static ClickDetailMemberLinksItemMethod FromCustom(string value)
    {
        return new ClickDetailMemberLinksItemMethod(value);
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

    public static bool operator ==(ClickDetailMemberLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClickDetailMemberLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClickDetailMemberLinksItemMethod value) => value.Value;

    public static explicit operator ClickDetailMemberLinksItemMethod(string value) => new(value);

    internal class ClickDetailMemberLinksItemMethodSerializer
        : JsonConverter<ClickDetailMemberLinksItemMethod>
    {
        public override ClickDetailMemberLinksItemMethod Read(
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
            return new ClickDetailMemberLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ClickDetailMemberLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ClickDetailMemberLinksItemMethod ReadAsPropertyName(
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
            return new ClickDetailMemberLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ClickDetailMemberLinksItemMethod value,
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
