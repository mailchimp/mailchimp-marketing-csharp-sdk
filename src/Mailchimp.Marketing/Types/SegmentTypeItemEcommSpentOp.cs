using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEcommSpentOp.SegmentTypeItemEcommSpentOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEcommSpentOp : IStringEnum
{
    public static readonly SegmentTypeItemEcommSpentOp Greater = new(Values.Greater);

    public static readonly SegmentTypeItemEcommSpentOp Less = new(Values.Less);

    public SegmentTypeItemEcommSpentOp(string value)
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
    public static SegmentTypeItemEcommSpentOp FromCustom(string value)
    {
        return new SegmentTypeItemEcommSpentOp(value);
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

    public static bool operator ==(SegmentTypeItemEcommSpentOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEcommSpentOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEcommSpentOp value) => value.Value;

    public static explicit operator SegmentTypeItemEcommSpentOp(string value) => new(value);

    internal class SegmentTypeItemEcommSpentOpSerializer
        : JsonConverter<SegmentTypeItemEcommSpentOp>
    {
        public override SegmentTypeItemEcommSpentOp Read(
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
            return new SegmentTypeItemEcommSpentOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommSpentOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEcommSpentOp ReadAsPropertyName(
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
            return new SegmentTypeItemEcommSpentOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEcommSpentOp value,
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
        public const string Greater = "greater";

        public const string Less = "less";
    }
}
