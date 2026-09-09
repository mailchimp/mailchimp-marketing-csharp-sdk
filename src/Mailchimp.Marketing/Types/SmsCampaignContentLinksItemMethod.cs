using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SmsCampaignContentLinksItemMethod.SmsCampaignContentLinksItemMethodSerializer)
)]
[Serializable]
public readonly record struct SmsCampaignContentLinksItemMethod : IStringEnum
{
    public static readonly SmsCampaignContentLinksItemMethod Get = new(Values.Get);

    public static readonly SmsCampaignContentLinksItemMethod Post = new(Values.Post);

    public static readonly SmsCampaignContentLinksItemMethod Put = new(Values.Put);

    public static readonly SmsCampaignContentLinksItemMethod Patch = new(Values.Patch);

    public static readonly SmsCampaignContentLinksItemMethod Delete = new(Values.Delete);

    public static readonly SmsCampaignContentLinksItemMethod Options = new(Values.Options);

    public static readonly SmsCampaignContentLinksItemMethod Head = new(Values.Head);

    public SmsCampaignContentLinksItemMethod(string value)
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
    public static SmsCampaignContentLinksItemMethod FromCustom(string value)
    {
        return new SmsCampaignContentLinksItemMethod(value);
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

    public static bool operator ==(SmsCampaignContentLinksItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SmsCampaignContentLinksItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SmsCampaignContentLinksItemMethod value) => value.Value;

    public static explicit operator SmsCampaignContentLinksItemMethod(string value) => new(value);

    internal class SmsCampaignContentLinksItemMethodSerializer
        : JsonConverter<SmsCampaignContentLinksItemMethod>
    {
        public override SmsCampaignContentLinksItemMethod Read(
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
            return new SmsCampaignContentLinksItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SmsCampaignContentLinksItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SmsCampaignContentLinksItemMethod ReadAsPropertyName(
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
            return new SmsCampaignContentLinksItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SmsCampaignContentLinksItemMethod value,
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
