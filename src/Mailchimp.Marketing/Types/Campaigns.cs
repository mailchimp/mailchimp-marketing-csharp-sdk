using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A summary of an individual campaign's settings and content.
/// </summary>
[Serializable]
public record Campaigns : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<CampaignsLinksItem>? Links { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("ab_split_opts")]
    public AbTestingOptions? AbSplitOpts { get; set; }

    /// <summary>
    /// The link to the campaign's archive version in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("archive_url")]
    public string? ArchiveUrl { get; set; }

    /// <summary>
    /// How the campaign's content is put together.
    /// </summary>
    [JsonPropertyName("content_type")]
    public CampaignsContentType? ContentType { get; set; }

    /// <summary>
    /// The date and time the campaign was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// Updates on campaigns in the process of sending.
    /// </summary>
    [JsonPropertyName("delivery_status")]
    public CampaignsDeliveryStatus? DeliveryStatus { get; set; }

    /// <summary>
    /// The total number of emails sent for this campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// A string that uniquely identifies this campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The original link to the campaign's archive version.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("long_archive_url")]
    public string? LongArchiveUrl { get; set; }

    /// <summary>
    /// Determines if the campaign needs its blocks refreshed by opening the web-based campaign editor. Deprecated and will always return false.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("needs_block_refresh")]
    public bool? NeedsBlockRefresh { get; set; }

    /// <summary>
    /// If this campaign is the child of another campaign, this identifies the parent campaign. For Example, for RSS or Automation children.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("parent_campaign_id")]
    public string? ParentCampaignId { get; set; }

    /// <summary>
    /// List settings for the campaign.
    /// </summary>
    [JsonPropertyName("recipients")]
    public CampaignsRecipients? Recipients { get; set; }

    /// <summary>
    /// For sent campaigns, a summary of opens, clicks, and e-commerce data.
    /// </summary>
    [JsonPropertyName("report_summary")]
    public CampaignsReportSummary? ReportSummary { get; set; }

    /// <summary>
    /// Determines if the campaign qualifies for the Campaign Resend Shortcuts. Only included when query parameter `include_resend_shortcuts` is `true`.
    /// </summary>
    [JsonPropertyName("resend_shortcut_eligibility")]
    public CampaignsResendShortcutEligibility? ResendShortcutEligibility { get; set; }

    /// <summary>
    /// Information about campaigns related through shortcuts.
    /// </summary>
    [JsonPropertyName("resend_shortcut_usage")]
    public CampaignsResendShortcutUsage? ResendShortcutUsage { get; set; }

    /// <summary>
    /// Determines if the campaign qualifies to be resent to non-openers.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("resendable")]
    public bool? Resendable { get; set; }

    /// <summary>
    /// [RSS](https://mailchimp.com/help/share-your-blog-posts-with-mailchimp/) options for a campaign.
    /// </summary>
    [JsonPropertyName("rss_opts")]
    public CampaignsRssOpts? RssOpts { get; set; }

    /// <summary>
    /// The date and time a campaign was sent.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("send_time")]
    public DateTime? SendTime { get; set; }

    /// <summary>
    /// The settings for your campaign, including subject, from name, reply-to address, and more.
    /// </summary>
    [JsonPropertyName("settings")]
    public CampaignsSettings? Settings { get; set; }

    /// <summary>
    /// The preview for the campaign, rendered by social networks like Facebook and Twitter. [Learn more](https://mailchimp.com/help/enable-and-customize-social-cards/).
    /// </summary>
    [JsonPropertyName("social_card")]
    public CampaignsSocialCard? SocialCard { get; set; }

    /// <summary>
    /// The current status of the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public CampaignsStatus? Status { get; set; }

    [JsonPropertyName("tracking")]
    public CampaignTrackingOptions? Tracking { get; set; }

    /// <summary>
    /// There are four types of [campaigns](https://mailchimp.com/help/getting-started-with-campaigns/) you can create in Mailchimp. A/B Split campaigns have been deprecated and variate campaigns should be used instead.
    /// </summary>
    [JsonPropertyName("type")]
    public CampaignsType? Type { get; set; }

    /// <summary>
    /// The settings specific to A/B test campaigns.
    /// </summary>
    [JsonPropertyName("variate_settings")]
    public CampaignsVariateSettings? VariateSettings { get; set; }

    /// <summary>
    /// The ID used in the Mailchimp web application. View this campaign in your Mailchimp account at `https://{dc}.admin.mailchimp.com/campaigns/show/?id={web_id}`.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("web_id")]
    public int? WebId { get; set; }

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
