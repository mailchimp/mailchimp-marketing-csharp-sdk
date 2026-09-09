using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// High level reporting stats for an outreach.
/// </summary>
[Serializable]
public record FacebookAdReportSummary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    [JsonPropertyName("conversion_rate")]
    public double? ConversionRate { get; set; }

    [JsonPropertyName("ecommerce")]
    public FacebookAdReportSummaryEcommerce? Ecommerce { get; set; }

    [JsonPropertyName("engagements")]
    public int? Engagements { get; set; }

    [JsonPropertyName("impressions")]
    public double? Impressions { get; set; }

    [JsonPropertyName("open_rate")]
    public double? OpenRate { get; set; }

    [JsonPropertyName("opens")]
    public int? Opens { get; set; }

    [JsonPropertyName("proxy_excluded_open_rate")]
    public double? ProxyExcludedOpenRate { get; set; }

    [JsonPropertyName("proxy_excluded_opens")]
    public int? ProxyExcludedOpens { get; set; }

    [JsonPropertyName("proxy_excluded_unique_opens")]
    public int? ProxyExcludedUniqueOpens { get; set; }

    [JsonPropertyName("reach")]
    public int? Reach { get; set; }

    [JsonPropertyName("subscriber_clicks")]
    public int? SubscriberClicks { get; set; }

    [JsonPropertyName("subscribes")]
    public int? Subscribes { get; set; }

    [JsonPropertyName("total_sent")]
    public int? TotalSent { get; set; }

    [JsonPropertyName("unique_opens")]
    public int? UniqueOpens { get; set; }

    [JsonPropertyName("unique_visits")]
    public int? UniqueVisits { get; set; }

    [JsonPropertyName("visits")]
    public int? Visits { get; set; }

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
