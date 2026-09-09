using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(CreateCampaignsRequestRssOptsFrequency.CreateCampaignsRequestRssOptsFrequencySerializer)
)]
[Serializable]
public readonly record struct CreateCampaignsRequestRssOptsFrequency : IStringEnum
{
    public static readonly CreateCampaignsRequestRssOptsFrequency Daily = new(Values.Daily);

    public static readonly CreateCampaignsRequestRssOptsFrequency Weekly = new(Values.Weekly);

    public static readonly CreateCampaignsRequestRssOptsFrequency Monthly = new(Values.Monthly);

    public CreateCampaignsRequestRssOptsFrequency(string value)
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
    public static CreateCampaignsRequestRssOptsFrequency FromCustom(string value)
    {
        return new CreateCampaignsRequestRssOptsFrequency(value);
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

    public static bool operator ==(CreateCampaignsRequestRssOptsFrequency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateCampaignsRequestRssOptsFrequency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateCampaignsRequestRssOptsFrequency value) =>
        value.Value;

    public static explicit operator CreateCampaignsRequestRssOptsFrequency(string value) =>
        new(value);

    internal class CreateCampaignsRequestRssOptsFrequencySerializer
        : JsonConverter<CreateCampaignsRequestRssOptsFrequency>
    {
        public override CreateCampaignsRequestRssOptsFrequency Read(
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
            return new CreateCampaignsRequestRssOptsFrequency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateCampaignsRequestRssOptsFrequency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateCampaignsRequestRssOptsFrequency ReadAsPropertyName(
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
            return new CreateCampaignsRequestRssOptsFrequency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateCampaignsRequestRssOptsFrequency value,
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
        public const string Daily = "daily";

        public const string Weekly = "weekly";

        public const string Monthly = "monthly";
    }
}
