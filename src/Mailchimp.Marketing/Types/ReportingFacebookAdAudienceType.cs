using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(ReportingFacebookAdAudienceType.ReportingFacebookAdAudienceTypeSerializer))]
[Serializable]
public readonly record struct ReportingFacebookAdAudienceType : IStringEnum
{
    public static readonly ReportingFacebookAdAudienceType CustomAudience = new(
        Values.CustomAudience
    );

    public static readonly ReportingFacebookAdAudienceType LookalikeAudience = new(
        Values.LookalikeAudience
    );

    public static readonly ReportingFacebookAdAudienceType InterestBasedAudience = new(
        Values.InterestBasedAudience
    );

    public ReportingFacebookAdAudienceType(string value)
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
    public static ReportingFacebookAdAudienceType FromCustom(string value)
    {
        return new ReportingFacebookAdAudienceType(value);
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

    public static bool operator ==(ReportingFacebookAdAudienceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportingFacebookAdAudienceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportingFacebookAdAudienceType value) => value.Value;

    public static explicit operator ReportingFacebookAdAudienceType(string value) => new(value);

    internal class ReportingFacebookAdAudienceTypeSerializer
        : JsonConverter<ReportingFacebookAdAudienceType>
    {
        public override ReportingFacebookAdAudienceType Read(
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
            return new ReportingFacebookAdAudienceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReportingFacebookAdAudienceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReportingFacebookAdAudienceType ReadAsPropertyName(
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
            return new ReportingFacebookAdAudienceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReportingFacebookAdAudienceType value,
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
        public const string CustomAudience = "Custom Audience";

        public const string LookalikeAudience = "Lookalike Audience";

        public const string InterestBasedAudience = "Interest-based Audience";
    }
}
