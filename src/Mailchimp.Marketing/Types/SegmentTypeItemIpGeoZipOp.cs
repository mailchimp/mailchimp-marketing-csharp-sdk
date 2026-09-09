using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemIpGeoZipOp.SegmentTypeItemIpGeoZipOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemIpGeoZipOp : IStringEnum
{
    public static readonly SegmentTypeItemIpGeoZipOp Ipgeoiszip = new(Values.Ipgeoiszip);

    public static readonly SegmentTypeItemIpGeoZipOp Ipgeonotzip = new(Values.Ipgeonotzip);

    public SegmentTypeItemIpGeoZipOp(string value)
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
    public static SegmentTypeItemIpGeoZipOp FromCustom(string value)
    {
        return new SegmentTypeItemIpGeoZipOp(value);
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

    public static bool operator ==(SegmentTypeItemIpGeoZipOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemIpGeoZipOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemIpGeoZipOp value) => value.Value;

    public static explicit operator SegmentTypeItemIpGeoZipOp(string value) => new(value);

    internal class SegmentTypeItemIpGeoZipOpSerializer : JsonConverter<SegmentTypeItemIpGeoZipOp>
    {
        public override SegmentTypeItemIpGeoZipOp Read(
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
            return new SegmentTypeItemIpGeoZipOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoZipOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemIpGeoZipOp ReadAsPropertyName(
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
            return new SegmentTypeItemIpGeoZipOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoZipOp value,
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
        public const string Ipgeoiszip = "ipgeoiszip";

        public const string Ipgeonotzip = "ipgeonotzip";
    }
}
