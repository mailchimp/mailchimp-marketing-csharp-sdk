using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateCampaignsRequest
{
    /// <summary>
    /// How the campaign's content is put together. The old drag and drop editor uses 'template' while the new editor uses 'multichannel'. Defaults to template.
    /// </summary>
    [JsonPropertyName("content_type")]
    public CreateCampaignsRequestContentType? ContentType { get; set; }

    /// <summary>
    /// List settings for the campaign.
    /// </summary>
    [JsonPropertyName("recipients")]
    public CreateCampaignsRequestRecipients? Recipients { get; set; }

    /// <summary>
    /// [RSS](https://mailchimp.com/help/share-your-blog-posts-with-mailchimp/) options, specific to an RSS campaign.
    /// </summary>
    [JsonPropertyName("rss_opts")]
    public CreateCampaignsRequestRssOpts? RssOpts { get; set; }

    /// <summary>
    /// The settings for your campaign, including subject, from name, reply-to address, and more.
    /// </summary>
    [JsonPropertyName("settings")]
    public CreateCampaignsRequestSettings? Settings { get; set; }

    /// <summary>
    /// The preview for the campaign, rendered by social networks like Facebook and Twitter. [Learn more](https://mailchimp.com/help/enable-and-customize-social-cards/).
    /// </summary>
    [JsonPropertyName("social_card")]
    public CreateCampaignsRequestSocialCard? SocialCard { get; set; }

    [JsonPropertyName("tracking")]
    public CampaignTrackingOptions? Tracking { get; set; }

    /// <summary>
    /// There are four types of [campaigns](https://mailchimp.com/help/getting-started-with-campaigns/) you can create in Mailchimp. A/B Split campaigns have been deprecated and variate campaigns should be used instead.
    /// </summary>
    [JsonPropertyName("type")]
    public required CreateCampaignsRequestType Type { get; set; }

    /// <summary>
    /// The settings specific to A/B test campaigns.
    /// </summary>
    [JsonPropertyName("variate_settings")]
    public CreateCampaignsRequestVariateSettings? VariateSettings { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
