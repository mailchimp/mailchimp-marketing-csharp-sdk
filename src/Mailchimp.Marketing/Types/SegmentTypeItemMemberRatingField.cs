using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemMemberRatingField.SegmentTypeItemMemberRatingFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemMemberRatingField : IStringEnum
{
    public static readonly SegmentTypeItemMemberRatingField Rating = new(Values.Rating);

    public SegmentTypeItemMemberRatingField(string value)
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
    public static SegmentTypeItemMemberRatingField FromCustom(string value)
    {
        return new SegmentTypeItemMemberRatingField(value);
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

    public static bool operator ==(SegmentTypeItemMemberRatingField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemMemberRatingField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemMemberRatingField value) => value.Value;

    public static explicit operator SegmentTypeItemMemberRatingField(string value) => new(value);

    internal class SegmentTypeItemMemberRatingFieldSerializer
        : JsonConverter<SegmentTypeItemMemberRatingField>
    {
        public override SegmentTypeItemMemberRatingField Read(
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
            return new SegmentTypeItemMemberRatingField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemMemberRatingField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemMemberRatingField ReadAsPropertyName(
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
            return new SegmentTypeItemMemberRatingField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemMemberRatingField value,
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
        public const string Rating = "rating";
    }
}
