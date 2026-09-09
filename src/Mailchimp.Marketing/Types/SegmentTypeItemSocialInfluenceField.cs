using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemSocialInfluenceField.SegmentTypeItemSocialInfluenceFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemSocialInfluenceField : IStringEnum
{
    public static readonly SegmentTypeItemSocialInfluenceField SocialInfluence = new(
        Values.SocialInfluence
    );

    public SegmentTypeItemSocialInfluenceField(string value)
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
    public static SegmentTypeItemSocialInfluenceField FromCustom(string value)
    {
        return new SegmentTypeItemSocialInfluenceField(value);
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

    public static bool operator ==(SegmentTypeItemSocialInfluenceField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialInfluenceField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialInfluenceField value) =>
        value.Value;

    public static explicit operator SegmentTypeItemSocialInfluenceField(string value) => new(value);

    internal class SegmentTypeItemSocialInfluenceFieldSerializer
        : JsonConverter<SegmentTypeItemSocialInfluenceField>
    {
        public override SegmentTypeItemSocialInfluenceField Read(
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
            return new SegmentTypeItemSocialInfluenceField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialInfluenceField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialInfluenceField ReadAsPropertyName(
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
            return new SegmentTypeItemSocialInfluenceField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialInfluenceField value,
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
        public const string SocialInfluence = "social_influence";
    }
}
