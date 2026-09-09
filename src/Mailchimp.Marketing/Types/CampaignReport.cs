using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Report details about a sent campaign.
/// </summary>
[Serializable]
public record CampaignReport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<CampaignReportLinksItem>? Links { get; set; }

    /// <summary>
    /// General stats about different groups of an A/B Split campaign. Does not return information about Multivariate Campaigns.
    /// </summary>
    [JsonPropertyName("ab_split")]
    public CampaignReportAbSplit? AbSplit { get; set; }

    /// <summary>
    /// The number of abuse reports generated for this campaign.
    /// </summary>
    [JsonPropertyName("abuse_reports")]
    public int? AbuseReports { get; set; }

    /// <summary>
    /// An object describing the bounce summary for the campaign.
    /// </summary>
    [JsonPropertyName("bounces")]
    public CampaignReportBounces? Bounces { get; set; }

    /// <summary>
    /// The title of the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("campaign_title")]
    public string? CampaignTitle { get; set; }

    /// <summary>
    /// An object describing the click activity for the campaign.
    /// </summary>
    [JsonPropertyName("clicks")]
    public CampaignReportClicks? Clicks { get; set; }

    /// <summary>
    /// Updates on campaigns in the process of sending.
    /// </summary>
    [JsonPropertyName("delivery_status")]
    public CampaignReportDeliveryStatus? DeliveryStatus { get; set; }

    /// <summary>
    /// E-Commerce stats for a campaign.
    /// </summary>
    [JsonPropertyName("ecommerce")]
    public CampaignReportEcommerce? Ecommerce { get; set; }

    /// <summary>
    /// The total number of emails sent for this campaign.
    /// </summary>
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// An object describing campaign engagement on Facebook.
    /// </summary>
    [JsonPropertyName("facebook_likes")]
    public CampaignReportFacebookLikes? FacebookLikes { get; set; }

    /// <summary>
    /// An object describing the forwards and forward activity for the campaign.
    /// </summary>
    [JsonPropertyName("forwards")]
    public CampaignReportForwards? Forwards { get; set; }

    /// <summary>
    /// A string that uniquely identifies this campaign.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The average campaign statistics for your industry.
    /// </summary>
    [JsonPropertyName("industry_stats")]
    public CampaignReportIndustryStats? IndustryStats { get; set; }

    /// <summary>
    /// The unique list id.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// The status of the list used, namely if it's deleted or disabled.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_is_active")]
    public bool? ListIsActive { get; set; }

    /// <summary>
    /// The name of the list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_name")]
    public string? ListName { get; set; }

    /// <summary>
    /// The average campaign statistics for your list. This won't be present if we haven't calculated it yet for this list.
    /// </summary>
    [JsonPropertyName("list_stats")]
    public CampaignReportListStats? ListStats { get; set; }

    /// <summary>
    /// An object describing the open activity for the campaign.
    /// </summary>
    [JsonPropertyName("opens")]
    public CampaignReportOpens? Opens { get; set; }

    /// <summary>
    /// The preview text for the campaign.
    /// </summary>
    [JsonPropertyName("preview_text")]
    public string? PreviewText { get; set; }

    /// <summary>
    /// For RSS campaigns, the date and time of the last send in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("rss_last_send")]
    public DateTime? RssLastSend { get; set; }

    /// <summary>
    /// The date and time a campaign was sent in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("send_time")]
    public DateTime? SendTime { get; set; }

    /// <summary>
    /// The url and password for the [VIP report](https://mailchimp.com/help/share-a-campaign-report/).
    /// </summary>
    [JsonPropertyName("share_report")]
    public CampaignReportShareReport? ShareReport { get; set; }

    /// <summary>
    /// The subject line for the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subject_line")]
    public string? SubjectLine { get; set; }

    /// <summary>
    /// An hourly breakdown of the performance of the campaign over the first 24 hours.
    /// </summary>
    [JsonPropertyName("timeseries")]
    public IEnumerable<CampaignReportTimeseriesItem>? Timeseries { get; set; }

    /// <summary>
    /// An hourly breakdown of sends, opens, and clicks if a campaign is sent using timewarp.
    /// </summary>
    [JsonPropertyName("timewarp")]
    public IEnumerable<CampaignReportTimewarpItem>? Timewarp { get; set; }

    /// <summary>
    /// The type of campaign (regular, plain-text, ab_split, rss, automation, variate, or auto).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The total number of unsubscribed members for this campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unsubscribed")]
    public int? Unsubscribed { get; set; }

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
