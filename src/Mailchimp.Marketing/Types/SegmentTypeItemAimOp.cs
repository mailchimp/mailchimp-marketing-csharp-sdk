using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemAimOp.SegmentTypeItemAimOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemAimOp : IStringEnum
{
    public static readonly SegmentTypeItemAimOp Open = new(Values.Open);

    public static readonly SegmentTypeItemAimOp Click = new(Values.Click);

    public static readonly SegmentTypeItemAimOp Sent = new(Values.Sent);

    public static readonly SegmentTypeItemAimOp Noopen = new(Values.Noopen);

    public static readonly SegmentTypeItemAimOp Noclick = new(Values.Noclick);

    public static readonly SegmentTypeItemAimOp Nosent = new(Values.Nosent);

    public SegmentTypeItemAimOp(string value)
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
    public static SegmentTypeItemAimOp FromCustom(string value)
    {
        return new SegmentTypeItemAimOp(value);
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

    public static bool operator ==(SegmentTypeItemAimOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemAimOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemAimOp value) => value.Value;

    public static explicit operator SegmentTypeItemAimOp(string value) => new(value);

    internal class SegmentTypeItemAimOpSerializer : JsonConverter<SegmentTypeItemAimOp>
    {
        public override SegmentTypeItemAimOp Read(
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
            return new SegmentTypeItemAimOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemAimOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemAimOp ReadAsPropertyName(
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
            return new SegmentTypeItemAimOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemAimOp value,
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
        public const string Open = "open";

        public const string Click = "click";

        public const string Sent = "sent";

        public const string Noopen = "noopen";

        public const string Noclick = "noclick";

        public const string Nosent = "nosent";
    }
}
