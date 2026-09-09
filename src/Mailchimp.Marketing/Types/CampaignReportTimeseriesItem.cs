using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CampaignReportTimeseriesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of emails sent in the timeseries.
    /// </summary>
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// The number of unique opens in the timeseries, excluding opens from email clients that use proxies.
    /// </summary>
    [JsonPropertyName("proxy_excluded_unique_opens")]
    public int? ProxyExcludedUniqueOpens { get; set; }

    /// <summary>
    /// The number of clicks in the timeseries.
    /// </summary>
    [JsonPropertyName("recipients_clicks")]
    public int? RecipientsClicks { get; set; }

    /// <summary>
    /// The date and time for the series in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// The number of unique opens in the timeseries.
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
