using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemSocialNetworkMemberField.SegmentTypeItemSocialNetworkMemberFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemSocialNetworkMemberField : IStringEnum
{
    public static readonly SegmentTypeItemSocialNetworkMemberField SocialNetwork = new(
        Values.SocialNetwork
    );

    public SegmentTypeItemSocialNetworkMemberField(string value)
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
    public static SegmentTypeItemSocialNetworkMemberField FromCustom(string value)
    {
        return new SegmentTypeItemSocialNetworkMemberField(value);
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

    public static bool operator ==(SegmentTypeItemSocialNetworkMemberField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialNetworkMemberField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialNetworkMemberField value) =>
        value.Value;

    public static explicit operator SegmentTypeItemSocialNetworkMemberField(string value) =>
        new(value);

    internal class SegmentTypeItemSocialNetworkMemberFieldSerializer
        : JsonConverter<SegmentTypeItemSocialNetworkMemberField>
    {
        public override SegmentTypeItemSocialNetworkMemberField Read(
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
            return new SegmentTypeItemSocialNetworkMemberField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkMemberField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialNetworkMemberField ReadAsPropertyName(
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
            return new SegmentTypeItemSocialNetworkMemberField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkMemberField value,
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
        public const string SocialNetwork = "social_network";
    }
}
