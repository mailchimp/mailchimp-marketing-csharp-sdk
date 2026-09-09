using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ListCampaignsRequestType.ListCampaignsRequestTypeSerializer))]
[Serializable]
public readonly record struct ListCampaignsRequestType : IStringEnum
{
    public static readonly ListCampaignsRequestType Regular = new(Values.Regular);

    public static readonly ListCampaignsRequestType Plaintext = new(Values.Plaintext);

    public static readonly ListCampaignsRequestType Absplit = new(Values.Absplit);

    public static readonly ListCampaignsRequestType Rss = new(Values.Rss);

    public static readonly ListCampaignsRequestType Variate = new(Values.Variate);

    public ListCampaignsRequestType(string value)
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
    public static ListCampaignsRequestType FromCustom(string value)
    {
        return new ListCampaignsRequestType(value);
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

    public static bool operator ==(ListCampaignsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListCampaignsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListCampaignsRequestType value) => value.Value;

    public static explicit operator ListCampaignsRequestType(string value) => new(value);

    internal class ListCampaignsRequestTypeSerializer : JsonConverter<ListCampaignsRequestType>
    {
        public override ListCampaignsRequestType Read(
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
            return new ListCampaignsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCampaignsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCampaignsRequestType ReadAsPropertyName(
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
            return new ListCampaignsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCampaignsRequestType value,
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
