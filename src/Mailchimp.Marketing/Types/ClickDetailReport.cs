using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A report of links clicked in a specific campaign.
/// </summary>
[Serializable]
public record ClickDetailReport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ClickDetailReportLinksItem>? Links { get; set; }

    /// <summary>
    /// A breakdown of clicks by different groups of an A/B Split campaign. Does not return information about Multivariate Campaigns.
    /// </summary>
    [JsonPropertyName("ab_split")]
    public ClickDetailReportAbSplit? AbSplit { get; set; }

    /// <summary>
    /// The campaign id.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// The percentage of total clicks a link generated for a campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("click_percentage")]
    public double? ClickPercentage { get; set; }

    /// <summary>
    /// The unique id for the link.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The date and time for the last recorded click for a link in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// The number of total clicks for a link.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_clicks")]
    public int? TotalClicks { get; set; }

    /// <summary>
    /// The percentage of unique clicks a link generated for a campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_click_percentage")]
    public double? UniqueClickPercentage { get; set; }

    /// <summary>
    /// Number of unique clicks for a link.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_clicks")]
    public int? UniqueClicks { get; set; }

    /// <summary>
    /// The URL for the link in the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("url")]
    public string? Url { get; set; }

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
