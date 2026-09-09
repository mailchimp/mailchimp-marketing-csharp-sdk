using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemSocialNetworkFollowOp.SegmentTypeItemSocialNetworkFollowOpSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemSocialNetworkFollowOp : IStringEnum
{
    public static readonly SegmentTypeItemSocialNetworkFollowOp Follow = new(Values.Follow);

    public static readonly SegmentTypeItemSocialNetworkFollowOp Notfollow = new(Values.Notfollow);

    public SegmentTypeItemSocialNetworkFollowOp(string value)
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
    public static SegmentTypeItemSocialNetworkFollowOp FromCustom(string value)
    {
        return new SegmentTypeItemSocialNetworkFollowOp(value);
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

    public static bool operator ==(SegmentTypeItemSocialNetworkFollowOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialNetworkFollowOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialNetworkFollowOp value) =>
        value.Value;

    public static explicit operator SegmentTypeItemSocialNetworkFollowOp(string value) =>
        new(value);

    internal class SegmentTypeItemSocialNetworkFollowOpSerializer
        : JsonConverter<SegmentTypeItemSocialNetworkFollowOp>
    {
        public override SegmentTypeItemSocialNetworkFollowOp Read(
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
            return new SegmentTypeItemSocialNetworkFollowOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkFollowOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialNetworkFollowOp ReadAsPropertyName(
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
            return new SegmentTypeItemSocialNetworkFollowOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkFollowOp value,
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
        public const string Follow = "follow";

        public const string Notfollow = "notfollow";
    }
}
