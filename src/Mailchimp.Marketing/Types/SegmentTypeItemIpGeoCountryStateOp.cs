using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemIpGeoCountryStateOp.SegmentTypeItemIpGeoCountryStateOpSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemIpGeoCountryStateOp : IStringEnum
{
    public static readonly SegmentTypeItemIpGeoCountryStateOp Ipgeocountry = new(
        Values.Ipgeocountry
    );

    public static readonly SegmentTypeItemIpGeoCountryStateOp Ipgeonotcountry = new(
        Values.Ipgeonotcountry
    );

    public static readonly SegmentTypeItemIpGeoCountryStateOp Ipgeostate = new(Values.Ipgeostate);

    public static readonly SegmentTypeItemIpGeoCountryStateOp Ipgeonotstate = new(
        Values.Ipgeonotstate
    );

    public SegmentTypeItemIpGeoCountryStateOp(string value)
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
    public static SegmentTypeItemIpGeoCountryStateOp FromCustom(string value)
    {
        return new SegmentTypeItemIpGeoCountryStateOp(value);
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

    public static bool operator ==(SegmentTypeItemIpGeoCountryStateOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemIpGeoCountryStateOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemIpGeoCountryStateOp value) => value.Value;

    public static explicit operator SegmentTypeItemIpGeoCountryStateOp(string value) => new(value);

    internal class SegmentTypeItemIpGeoCountryStateOpSerializer
        : JsonConverter<SegmentTypeItemIpGeoCountryStateOp>
    {
        public override SegmentTypeItemIpGeoCountryStateOp Read(
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
            return new SegmentTypeItemIpGeoCountryStateOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoCountryStateOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemIpGeoCountryStateOp ReadAsPropertyName(
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
            return new SegmentTypeItemIpGeoCountryStateOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemIpGeoCountryStateOp value,
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
        public const string Ipgeocountry = "ipgeocountry";

        public const string Ipgeonotcountry = "ipgeonotcountry";

        public const string Ipgeostate = "ipgeostate";

        public const string Ipgeonotstate = "ipgeonotstate";
    }
}
