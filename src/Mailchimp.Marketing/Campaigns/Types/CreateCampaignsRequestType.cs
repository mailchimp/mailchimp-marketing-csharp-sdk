using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(CreateCampaignsRequestType.CreateCampaignsRequestTypeSerializer))]
[Serializable]
public readonly record struct CreateCampaignsRequestType : IStringEnum
{
    public static readonly CreateCampaignsRequestType Regular = new(Values.Regular);

    public static readonly CreateCampaignsRequestType Plaintext = new(Values.Plaintext);

    public static readonly CreateCampaignsRequestType Absplit = new(Values.Absplit);

    public static readonly CreateCampaignsRequestType Rss = new(Values.Rss);

    public static readonly CreateCampaignsRequestType Variate = new(Values.Variate);

    public CreateCampaignsRequestType(string value)
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
    public static CreateCampaignsRequestType FromCustom(string value)
    {
        return new CreateCampaignsRequestType(value);
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

    public static bool operator ==(CreateCampaignsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateCampaignsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateCampaignsRequestType value) => value.Value;

    public static explicit operator CreateCampaignsRequestType(string value) => new(value);

    internal class CreateCampaignsRequestTypeSerializer : JsonConverter<CreateCampaignsRequestType>
    {
        public override CreateCampaignsRequestType Read(
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
            return new CreateCampaignsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateCampaignsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateCampaignsRequestType ReadAsPropertyName(
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
            return new CreateCampaignsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateCampaignsRequestType value,
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
        public const string Regular = "regular";

        public const string Plaintext = "plaintext";

        public const string Absplit = "absplit";

        public const string Rss = "rss";

        public const string Variate = "variate";
    }
}
