using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSignupSourceOp.SegmentTypeItemSignupSourceOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSignupSourceOp : IStringEnum
{
    public static readonly SegmentTypeItemSignupSourceOp SourceIs = new(Values.SourceIs);

    public static readonly SegmentTypeItemSignupSourceOp SourceNot = new(Values.SourceNot);

    public SegmentTypeItemSignupSourceOp(string value)
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
    public static SegmentTypeItemSignupSourceOp FromCustom(string value)
    {
        return new SegmentTypeItemSignupSourceOp(value);
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

    public static bool operator ==(SegmentTypeItemSignupSourceOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSignupSourceOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSignupSourceOp value) => value.Value;

    public static explicit operator SegmentTypeItemSignupSourceOp(string value) => new(value);

    internal class SegmentTypeItemSignupSourceOpSerializer
        : JsonConverter<SegmentTypeItemSignupSourceOp>
    {
        public override SegmentTypeItemSignupSourceOp Read(
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
            return new SegmentTypeItemSignupSourceOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSignupSourceOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSignupSourceOp ReadAsPropertyName(
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
            return new SegmentTypeItemSignupSourceOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSignupSourceOp value,
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
        public const string SourceIs = "source_is";

        public const string SourceNot = "source_not";
    }
}
