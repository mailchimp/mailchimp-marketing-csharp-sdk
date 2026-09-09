using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CampaignsContentType.CampaignsContentTypeSerializer))]
[Serializable]
public readonly record struct CampaignsContentType : IStringEnum
{
    public static readonly CampaignsContentType Template = new(Values.Template);

    public static readonly CampaignsContentType Html = new(Values.Html);

    public static readonly CampaignsContentType Url = new(Values.Url);

    public static readonly CampaignsContentType Multichannel = new(Values.Multichannel);

    public CampaignsContentType(string value)
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
    public static CampaignsContentType FromCustom(string value)
    {
        return new CampaignsContentType(value);
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

    public static bool operator ==(CampaignsContentType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CampaignsContentType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CampaignsContentType value) => value.Value;

    public static explicit operator CampaignsContentType(string value) => new(value);

    internal class CampaignsContentTypeSerializer : JsonConverter<CampaignsContentType>
    {
        public override CampaignsContentType Read(
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
            return new CampaignsContentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CampaignsContentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CampaignsContentType ReadAsPropertyName(
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
            return new CampaignsContentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CampaignsContentType value,
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
        public const string Template = "template";

        public const string Html = "html";

        public const string Url = "url";

        public const string Multichannel = "multichannel";
    }
}
