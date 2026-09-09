using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemIpGeoInZipField.SegmentTypeItemIpGeoInZipFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemIpGeoInZipField : IStringEnum
{
    public static readonly SegmentTypeItemIpGeoInZipField Ipgeo = new(Values.Ipgeo);

    public SegmentTypeItemIpGeoInZipField(string value)
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
    public static SegmentTypeItemIpGeoInZipField FromCustom(string value)
    {
        return new SegmentTypeItemIpGeoInZipField(value);
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

    public static bool operator ==(SegmentTypeItemIpGeoInZipField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemIpGeoInZipField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemIpGeoInZipField value) => value.Value;

    public static explicit operator SegmentTypeItemIpGeoInZipField(string value) => new(value);

    internal class SegmentTypeItemIpGeoInZipFieldSerializer
        : JsonConverter<SegmentTypeItemIpGeoInZipField>
    {
        public override SegmentTypeItemIpGeoInZipField Read(
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
            return new SegmentTypeItemIpGeoInZipField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoInZipField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemIpGeoInZipField ReadAsPropertyName(
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
            return new SegmentTypeItemIpGeoInZipField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoInZipField value,
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
