using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemIpGeoZipField.SegmentTypeItemIpGeoZipFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemIpGeoZipField : IStringEnum
{
    public static readonly SegmentTypeItemIpGeoZipField Ipgeo = new(Values.Ipgeo);

    public SegmentTypeItemIpGeoZipField(string value)
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
    public static SegmentTypeItemIpGeoZipField FromCustom(string value)
    {
        return new SegmentTypeItemIpGeoZipField(value);
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

    public static bool operator ==(SegmentTypeItemIpGeoZipField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemIpGeoZipField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemIpGeoZipField value) => value.Value;

    public static explicit operator SegmentTypeItemIpGeoZipField(string value) => new(value);

    internal class SegmentTypeItemIpGeoZipFieldSerializer
        : JsonConverter<SegmentTypeItemIpGeoZipField>
    {
        public override SegmentTypeItemIpGeoZipField Read(
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
            return new SegmentTypeItemIpGeoZipField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoZipField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemIpGeoZipField ReadAsPropertyName(
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
            return new SegmentTypeItemIpGeoZipField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoZipField value,
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
