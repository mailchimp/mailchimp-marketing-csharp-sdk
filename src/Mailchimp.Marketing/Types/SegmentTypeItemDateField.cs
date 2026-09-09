using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemDateField.SegmentTypeItemDateFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemDateField : IStringEnum
{
    public static readonly SegmentTypeItemDateField TimestampOpt = new(Values.TimestampOpt);

    public static readonly SegmentTypeItemDateField InfoChanged = new(Values.InfoChanged);

    public static readonly SegmentTypeItemDateField EcommDate = new(Values.EcommDate);

    public SegmentTypeItemDateField(string value)
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
    public static SegmentTypeItemDateField FromCustom(string value)
    {
        return new SegmentTypeItemDateField(value);
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

    public static bool operator ==(SegmentTypeItemDateField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemDateField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemDateField value) => value.Value;

    public static explicit operator SegmentTypeItemDateField(string value) => new(value);

    internal class SegmentTypeItemDateFieldSerializer : JsonConverter<SegmentTypeItemDateField>
    {
        public override SegmentTypeItemDateField Read(
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
            return new SegmentTypeItemDateField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemDateField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemDateField ReadAsPropertyName(
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
            return new SegmentTypeItemDateField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemDateField value,
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
        public const string TimestampOpt = "timestamp_opt";

        public const string InfoChanged = "info_changed";

        public const string EcommDate = "ecomm_date";
    }
}
