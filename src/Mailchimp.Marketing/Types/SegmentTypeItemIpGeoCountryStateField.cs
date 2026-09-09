using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemIpGeoCountryStateField.SegmentTypeItemIpGeoCountryStateFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemIpGeoCountryStateField : IStringEnum
{
    public static readonly SegmentTypeItemIpGeoCountryStateField Ipgeo = new(Values.Ipgeo);

    public SegmentTypeItemIpGeoCountryStateField(string value)
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
    public static SegmentTypeItemIpGeoCountryStateField FromCustom(string value)
    {
        return new SegmentTypeItemIpGeoCountryStateField(value);
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

    public static bool operator ==(SegmentTypeItemIpGeoCountryStateField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemIpGeoCountryStateField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemIpGeoCountryStateField value) =>
        value.Value;

    public static explicit operator SegmentTypeItemIpGeoCountryStateField(string value) =>
        new(value);

    internal class SegmentTypeItemIpGeoCountryStateFieldSerializer
        : JsonConverter<SegmentTypeItemIpGeoCountryStateField>
    {
        public override SegmentTypeItemIpGeoCountryStateField Read(
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
            return new SegmentTypeItemIpGeoCountryStateField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoCountryStateField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemIpGeoCountryStateField ReadAsPropertyName(
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
            return new SegmentTypeItemIpGeoCountryStateField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoCountryStateField value,
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
        public const string Ipgeo = "ipgeo";
    }
}
