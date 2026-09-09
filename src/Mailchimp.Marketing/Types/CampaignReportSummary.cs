using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// For sent campaigns, a summary of opens and clicks.
/// </summary>
[Serializable]
public record CampaignReportSummary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of unique clicks divided by the total number of successful deliveries.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    /// <summary>
    /// The total number of clicks for an campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    /// <summary>
    /// E-Commerce stats for a campaign.
    /// </summary>
    [JsonPropertyName("ecommerce")]
    public CampaignReportSummaryEcommerce? Ecommerce { get; set; }

    /// <summary>
    /// The number of unique opens divided by the total number of successful deliveries.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("open_rate")]
    public double? OpenRate { get; set; }

    /// <summary>
    /// The total number of opens for a campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("opens")]
    public int? Opens { get; set; }

    /// <summary>
    /// The number of unique clicks.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subscriber_clicks")]
    public int? SubscriberClicks { get; set; }

    /// <summary>
    /// The number of unique opens.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_opens")]
    public int? UniqueOpens { get; set; }

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
