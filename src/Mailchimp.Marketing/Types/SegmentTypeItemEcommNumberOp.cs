using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEcommNumberOp.SegmentTypeItemEcommNumberOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEcommNumberOp : IStringEnum
{
    public static readonly SegmentTypeItemEcommNumberOp Is = new(Values.Is);

    public static readonly SegmentTypeItemEcommNumberOp Not = new(Values.Not);

    public static readonly SegmentTypeItemEcommNumberOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemEcommNumberOp Less = new(Values.Less);

    public SegmentTypeItemEcommNumberOp(string value)
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
    public static SegmentTypeItemEcommNumberOp FromCustom(string value)
    {
        return new SegmentTypeItemEcommNumberOp(value);
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

    public static bool operator ==(SegmentTypeItemEcommNumberOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommNumberOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommNumberOp value) => value.Value;

    public static explicit operator SegmentTypeItemEcommNumberOp(string value) => new(value);

    internal class SegmentTypeItemEcommNumberOpSerializer
        : JsonConverter<SegmentTypeItemEcommNumberOp>
    {
        public override SegmentTypeItemEcommNumberOp Read(
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
            return new SegmentTypeItemEcommNumberOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommNumberOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommNumberOp ReadAsPropertyName(
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
            return new SegmentTypeItemEcommNumberOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommNumberOp value,
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
        public const string Is = "is";

        public const string Not = "not";

        public const string Greater = "greater";

        public const string Less = "less";
    }
}
