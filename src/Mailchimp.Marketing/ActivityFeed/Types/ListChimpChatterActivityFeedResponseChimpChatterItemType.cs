using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[JsonConverter(
    typeof(ListChimpChatterActivityFeedResponseChimpChatterItemType.ListChimpChatterActivityFeedResponseChimpChatterItemTypeSerializer)
)]
[Serializable]
public readonly record struct ListChimpChatterActivityFeedResponseChimpChatterItemType : IStringEnum
{
    public static readonly ListChimpChatterActivityFeedResponseChimpChatterItemType ListsNewSubscriber =
        new(Values.ListsNewSubscriber);

    public static readonly ListChimpChatterActivityFeedResponseChimpChatterItemType ListsUnsubscribes =
        new(Values.ListsUnsubscribes);

    public static readonly ListChimpChatterActivityFeedResponseChimpChatterItemType ListsProfileUpdates =
        new(Values.ListsProfileUpdates);

    public static readonly ListChimpChatterActivityFeedResponseChimpChatterItemType CampaignsFacebookLikes =
        new(Values.CampaignsFacebookLikes);

    public static readonly ListChimpChatterActivityFeedResponseChimpChatterItemType CampaignsForwardToFriend =
        new(Values.CampaignsForwardToFriend);

    public static readonly ListChimpChatterActivityFeedResponseChimpChatterItemType ListsImports =
        new(Values.ListsImports);

    public ListChimpChatterActivityFeedResponseChimpChatterItemType(string value)
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
    public static ListChimpChatterActivityFeedResponseChimpChatterItemType FromCustom(string value)
    {
        return new ListChimpChatterActivityFeedResponseChimpChatterItemType(value);
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

    public static bool operator ==(
        ListChimpChatterActivityFeedResponseChimpChatterItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListChimpChatterActivityFeedResponseChimpChatterItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListChimpChatterActivityFeedResponseChimpChatterItemType value
    ) => value.Value;

    public static explicit operator ListChimpChatterActivityFeedResponseChimpChatterItemType(
        string value
    ) => new(value);

    internal class ListChimpChatterActivityFeedResponseChimpChatterItemTypeSerializer
        : JsonConverter<ListChimpChatterActivityFeedResponseChimpChatterItemType>
    {
        public override ListChimpChatterActivityFeedResponseChimpChatterItemType Read(
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
            return new ListChimpChatterActivityFeedResponseChimpChatterItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListChimpChatterActivityFeedResponseChimpChatterItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListChimpChatterActivityFeedResponseChimpChatterItemType ReadAsPropertyName(
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
            return new ListChimpChatterActivityFeedResponseChimpChatterItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListChimpChatterActivityFeedResponseChimpChatterItemType value,
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
        public const string ListsNewSubscriber = "lists:new-subscriber";

        public const string ListsUnsubscribes = "lists:unsubscribes";

        public const string ListsProfileUpdates = "lists:profile-updates";

        public const string CampaignsFacebookLikes = "campaigns:facebook-likes";

        public const string CampaignsForwardToFriend = "campaigns:forward-to-friend";

        public const string ListsImports = "lists:imports";
    }
}
