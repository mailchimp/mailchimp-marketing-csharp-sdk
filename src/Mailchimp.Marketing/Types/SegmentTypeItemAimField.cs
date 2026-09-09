using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemAimField.SegmentTypeItemAimFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemAimField : IStringEnum
{
    public static readonly SegmentTypeItemAimField Aim = new(Values.Aim);

    public SegmentTypeItemAimField(string value)
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
    public static SegmentTypeItemAimField FromCustom(string value)
    {
        return new SegmentTypeItemAimField(value);
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

    public static bool operator ==(SegmentTypeItemAimField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemAimField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemAimField value) => value.Value;

    public static explicit operator SegmentTypeItemAimField(string value) => new(value);

    internal class SegmentTypeItemAimFieldSerializer : JsonConverter<SegmentTypeItemAimField>
    {
        public override SegmentTypeItemAimField Read(
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
            return new SegmentTypeItemAimField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemAimField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemAimField ReadAsPropertyName(
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
            return new SegmentTypeItemAimField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemAimField value,
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
        public const string Aim = "aim";
    }
}
