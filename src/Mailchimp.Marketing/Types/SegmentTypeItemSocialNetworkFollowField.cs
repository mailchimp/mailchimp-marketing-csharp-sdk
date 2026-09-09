using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemSocialNetworkFollowField.SegmentTypeItemSocialNetworkFollowFieldSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemSocialNetworkFollowField : IStringEnum
{
    public static readonly SegmentTypeItemSocialNetworkFollowField SocialNetwork = new(
        Values.SocialNetwork
    );

    public SegmentTypeItemSocialNetworkFollowField(string value)
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
    public static SegmentTypeItemSocialNetworkFollowField FromCustom(string value)
    {
        return new SegmentTypeItemSocialNetworkFollowField(value);
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

    public static bool operator ==(SegmentTypeItemSocialNetworkFollowField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialNetworkFollowField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialNetworkFollowField value) =>
        value.Value;

    public static explicit operator SegmentTypeItemSocialNetworkFollowField(string value) =>
        new(value);

    internal class SegmentTypeItemSocialNetworkFollowFieldSerializer
        : JsonConverter<SegmentTypeItemSocialNetworkFollowField>
    {
        public override SegmentTypeItemSocialNetworkFollowField Read(
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
            return new SegmentTypeItemSocialNetworkFollowField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkFollowField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialNetworkFollowField ReadAsPropertyName(
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
            return new SegmentTypeItemSocialNetworkFollowField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkFollowField value,
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
