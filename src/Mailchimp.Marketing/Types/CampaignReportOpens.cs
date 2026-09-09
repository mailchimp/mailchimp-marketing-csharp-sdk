using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An object describing the open activity for the campaign.
/// </summary>
[Serializable]
public record CampaignReportOpens : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The date and time of the last recorded open in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_open")]
    public DateTime? LastOpen { get; set; }

    /// <summary>
    /// The number of unique opens for a campaign divided by the total number of successful deliveries.
    /// </summary>
    [JsonPropertyName("open_rate")]
    public double? OpenRate { get; set; }

    /// <summary>
    /// The total number of opens for a campaign.
    /// </summary>
    [JsonPropertyName("opens_total")]
    public int? OpensTotal { get; set; }

    /// <summary>
    /// The average unique open rate for a campaign, excluding opens from email clients that use proxies.
    /// </summary>
    [JsonPropertyName("proxy_excluded_open_rate")]
    public double? ProxyExcludedOpenRate { get; set; }

    /// <summary>
    /// The total number of opens for a campaign, excluding opens from email clients that use proxies.
    /// </summary>
    [JsonPropertyName("proxy_excluded_opens")]
    public int? ProxyExcludedOpens { get; set; }

    /// <summary>
    /// The total number of unique opens for a campaign, excluding opens from email clients that use proxies.
    /// </summary>
    [JsonPropertyName("proxy_excluded_unique_opens")]
    public int? ProxyExcludedUniqueOpens { get; set; }

    /// <summary>
    /// The total number of unique opens for a campaign.
    /// </summary>
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
