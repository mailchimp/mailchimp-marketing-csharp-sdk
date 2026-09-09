using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSignupSourceField.SegmentTypeItemSignupSourceFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSignupSourceField : IStringEnum
{
    public static readonly SegmentTypeItemSignupSourceField Source = new(Values.Source);

    public SegmentTypeItemSignupSourceField(string value)
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
    public static SegmentTypeItemSignupSourceField FromCustom(string value)
    {
        return new SegmentTypeItemSignupSourceField(value);
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

    public static bool operator ==(SegmentTypeItemSignupSourceField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSignupSourceField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSignupSourceField value) => value.Value;

    public static explicit operator SegmentTypeItemSignupSourceField(string value) => new(value);

    internal class SegmentTypeItemSignupSourceFieldSerializer
        : JsonConverter<SegmentTypeItemSignupSourceField>
    {
        public override SegmentTypeItemSignupSourceField Read(
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
            return new SegmentTypeItemSignupSourceField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSignupSourceField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSignupSourceField ReadAsPropertyName(
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
            return new SegmentTypeItemSignupSourceField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSignupSourceField value,
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
        public const string Source = "source";
    }
}
