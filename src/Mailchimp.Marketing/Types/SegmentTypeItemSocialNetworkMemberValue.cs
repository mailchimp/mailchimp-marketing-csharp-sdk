using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(SegmentTypeItemSocialNetworkMemberValue.SegmentTypeItemSocialNetworkMemberValueSerializer)
)]
[Serializable]
public readonly record struct SegmentTypeItemSocialNetworkMemberValue : IStringEnum
{
    public static readonly SegmentTypeItemSocialNetworkMemberValue Twitter = new(Values.Twitter);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Facebook = new(Values.Facebook);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Linkedin = new(Values.Linkedin);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Flickr = new(Values.Flickr);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Foursquare = new(
        Values.Foursquare
    );

    public static readonly SegmentTypeItemSocialNetworkMemberValue Lastfm = new(Values.Lastfm);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Myspace = new(Values.Myspace);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Quora = new(Values.Quora);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Vimeo = new(Values.Vimeo);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Yelp = new(Values.Yelp);

    public static readonly SegmentTypeItemSocialNetworkMemberValue Youtube = new(Values.Youtube);

    public SegmentTypeItemSocialNetworkMemberValue(string value)
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
    public static SegmentTypeItemSocialNetworkMemberValue FromCustom(string value)
    {
        return new SegmentTypeItemSocialNetworkMemberValue(value);
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

    public static bool operator ==(SegmentTypeItemSocialNetworkMemberValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SegmentTypeItemSocialNetworkMemberValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SegmentTypeItemSocialNetworkMemberValue value) =>
        value.Value;

    public static explicit operator SegmentTypeItemSocialNetworkMemberValue(string value) =>
        new(value);

    internal class SegmentTypeItemSocialNetworkMemberValueSerializer
        : JsonConverter<SegmentTypeItemSocialNetworkMemberValue>
    {
        public override SegmentTypeItemSocialNetworkMemberValue Read(
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
            return new SegmentTypeItemSocialNetworkMemberValue(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkMemberValue value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SegmentTypeItemSocialNetworkMemberValue ReadAsPropertyName(
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
            return new SegmentTypeItemSocialNetworkMemberValue(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SegmentTypeItemSocialNetworkMemberValue value,
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
        public const string Twitter = "twitter";

        public const string Facebook = "facebook";

        public const string Linkedin = "linkedin";

        public const string Flickr = "flickr";

        public const string Foursquare = "foursquare";

        public const string Lastfm = "lastfm";

        public const string Myspace = "myspace";

        public const string Quora = "quora";

        public const string Vimeo = "vimeo";

        public const string Yelp = "yelp";

        public const string Youtube = "youtube";
    }
}
