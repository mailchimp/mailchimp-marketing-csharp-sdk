using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateCampaignsRequest
{
    /// <summary>
    /// The unique id for the campaign.
    /// </summary>
    [JsonIgnore]
    public required string CampaignId { get; set; }

    /// <summary>
    /// List settings for the campaign.
    /// </summary>
    [JsonPropertyName("recipients")]
    public UpdateCampaignsRequestRecipients? Recipients { get; set; }

    /// <summary>
    /// [RSS](https://mailchimp.com/help/share-your-blog-posts-with-mailchimp/) options for a campaign.
    /// </summary>
    [JsonPropertyName("rss_opts")]
    public UpdateCampaignsRequestRssOpts? RssOpts { get; set; }

    /// <summary>
    /// The settings for your campaign, including subject, from name, reply-to address, and more.
    /// </summary>
    [JsonPropertyName("settings")]
    public UpdateCampaignsRequestSettings? Settings { get; set; }

    /// <summary>
    /// The preview for the campaign, rendered by social networks like Facebook and Twitter. [Learn more](https://mailchimp.com/help/enable-and-customize-social-cards/).
    /// </summary>
    [JsonPropertyName("social_card")]
    public UpdateCampaignsRequestSocialCard? SocialCard { get; set; }

    [JsonPropertyName("tracking")]
    public CampaignTrackingOptions? Tracking { get; set; }

    /// <summary>
    /// The settings specific to A/B test campaigns.
    /// </summary>
    [JsonPropertyName("variate_settings")]
    public UpdateCampaignsRequestVariateSettings? VariateSettings { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
