using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateCampaignsRequestContentType.CreateCampaignsRequestContentTypeSerializer)
)]
[Serializable]
public readonly record struct CreateCampaignsRequestContentType : IStringEnum
{
    public static readonly CreateCampaignsRequestContentType Template = new(Values.Template);

    public static readonly CreateCampaignsRequestContentType Multichannel = new(
        Values.Multichannel
    );

    public CreateCampaignsRequestContentType(string value)
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
    public static CreateCampaignsRequestContentType FromCustom(string value)
    {
        return new CreateCampaignsRequestContentType(value);
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

    public static bool operator ==(CreateCampaignsRequestContentType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateCampaignsRequestContentType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateCampaignsRequestContentType value) => value.Value;

    public static explicit operator CreateCampaignsRequestContentType(string value) => new(value);

    internal class CreateCampaignsRequestContentTypeSerializer
        : JsonConverter<CreateCampaignsRequestContentType>
    {
        public override CreateCampaignsRequestContentType Read(
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
            return new CreateCampaignsRequestContentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateCampaignsRequestContentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateCampaignsRequestContentType ReadAsPropertyName(
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
            return new CreateCampaignsRequestContentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateCampaignsRequestContentType value,
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

        public const string Multichannel = "multichannel";
    }
}
