using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// [RSS](https://mailchimp.com/help/share-your-blog-posts-with-mailchimp/) options, specific to an RSS campaign.
/// </summary>
[Serializable]
public record CreateCampaignsRequestRssOpts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether to add CSS to images in the RSS feed to constrain their width in campaigns.
    /// </summary>
    [JsonPropertyName("constrain_rss_img")]
    public bool? ConstrainRssImg { get; set; }

    /// <summary>
    /// The URL for the RSS feed.
    /// </summary>
    [JsonPropertyName("feed_url")]
    public required string FeedUrl { get; set; }

    /// <summary>
    /// The frequency of the RSS Campaign.
    /// </summary>
    [JsonPropertyName("frequency")]
    public required CreateCampaignsRequestRssOptsFrequency Frequency { get; set; }

    /// <summary>
    /// The schedule for sending the RSS Campaign.
    /// </summary>
    [JsonPropertyName("schedule")]
    public CreateCampaignsRequestRssOptsSchedule? Schedule { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
