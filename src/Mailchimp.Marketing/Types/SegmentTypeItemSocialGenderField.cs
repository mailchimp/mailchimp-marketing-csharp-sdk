using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(typeof(SegmentTypeItemSocialGenderField.SegmentTypeItemSocialGenderFieldSerializer))]
[Serializable]
public readonly record struct SegmentTypeItemSocialGenderField : IStringEnum
{
    public static readonly SegmentTypeItemSocialGenderField SocialGender = new(Values.SocialGender);

    public SegmentTypeItemSocialGenderField(string value)
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
    public static SegmentTypeItemSocialGenderField FromCustom(string value)
    {
        return new SegmentTypeItemSocialGenderField(value);
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

    public static bool operator ==(SegmentTypeItemSocialGenderField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialGenderField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialGenderField value) => value.Value;

    public static explicit operator SegmentTypeItemSocialGenderField(string value) => new(value);

    internal class SegmentTypeItemSocialGenderFieldSerializer
        : JsonConverter<SegmentTypeItemSocialGenderField>
    {
        public override SegmentTypeItemSocialGenderField Read(
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
            return new SegmentTypeItemSocialGenderField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialGenderField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialGenderField ReadAsPropertyName(
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
            return new SegmentTypeItemSocialGenderField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialGenderField value,
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
        public const string SocialGender = "social_gender";
    }
}
