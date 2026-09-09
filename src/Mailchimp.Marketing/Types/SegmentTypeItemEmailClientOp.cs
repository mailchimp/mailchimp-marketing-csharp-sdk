using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemEmailClientOp.SegmentTypeItemEmailClientOpSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemEmailClientOp : IStringEnum
{
    public static readonly SegmentTypeItemEmailClientOp ClientIs = new(Values.ClientIs);

    public static readonly SegmentTypeItemEmailClientOp ClientNot = new(Values.ClientNot);

    public SegmentTypeItemEmailClientOp(string value)
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
    public static SegmentTypeItemEmailClientOp FromCustom(string value)
    {
        return new SegmentTypeItemEmailClientOp(value);
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

    public static bool operator ==(SegmentTypeItemEmailClientOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemEmailClientOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemEmailClientOp value) => value.Value;

    public static explicit operator SegmentTypeItemEmailClientOp(string value) => new(value);

    internal class SegmentTypeItemEmailClientOpSerializer
        : JsonConverter<SegmentTypeItemEmailClientOp>
    {
        public override SegmentTypeItemEmailClientOp Read(
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
            return new SegmentTypeItemEmailClientOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemEmailClientOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemEmailClientOp ReadAsPropertyName(
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
            return new SegmentTypeItemEmailClientOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemEmailClientOp value,
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
        public const string ClientIs = "client_is";

        public const string ClientNot = "client_not";
    }
}
