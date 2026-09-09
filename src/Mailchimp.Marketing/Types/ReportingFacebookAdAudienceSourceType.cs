using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ReportingFacebookAdAudienceSourceType.ReportingFacebookAdAudienceSourceTypeSerializer)
)]
[Serializable]
public readonly record struct ReportingFacebookAdAudienceSourceType : IStringEnum
{
    public static readonly ReportingFacebookAdAudienceSourceType Facebook = new(Values.Facebook);

    public static readonly ReportingFacebookAdAudienceSourceType List = new(Values.List);

    public ReportingFacebookAdAudienceSourceType(string value)
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
    public static ReportingFacebookAdAudienceSourceType FromCustom(string value)
    {
        return new ReportingFacebookAdAudienceSourceType(value);
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

    public static bool operator ==(ReportingFacebookAdAudienceSourceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportingFacebookAdAudienceSourceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportingFacebookAdAudienceSourceType value) =>
        value.Value;

    public static explicit operator ReportingFacebookAdAudienceSourceType(string value) =>
        new(value);

    internal class ReportingFacebookAdAudienceSourceTypeSerializer
        : JsonConverter<ReportingFacebookAdAudienceSourceType>
    {
        public override ReportingFacebookAdAudienceSourceType Read(
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
            return new ReportingFacebookAdAudienceSourceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReportingFacebookAdAudienceSourceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReportingFacebookAdAudienceSourceType ReadAsPropertyName(
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
            return new ReportingFacebookAdAudienceSourceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReportingFacebookAdAudienceSourceType value,
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
        public const string Facebook = "facebook";

        public const string List = "list";
    }
}
