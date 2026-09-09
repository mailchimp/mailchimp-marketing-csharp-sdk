using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The average campaign statistics for your industry.
/// </summary>
[Serializable]
public record CampaignReportIndustryStats : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The industry abuse rate.
    /// </summary>
    [JsonPropertyName("abuse_rate")]
    public double? AbuseRate { get; set; }

    /// <summary>
    /// The industry bounce rate.
    /// </summary>
    [JsonPropertyName("bounce_rate")]
    public double? BounceRate { get; set; }

    /// <summary>
    /// The industry click rate.
    /// </summary>
    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    /// <summary>
    /// The industry open rate.
    /// </summary>
    [JsonPropertyName("open_rate")]
    public double? OpenRate { get; set; }

    /// <summary>
    /// The type of business industry associated with your account. For example: retail, education, etc.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The industry unopened rate.
    /// </summary>
    [JsonPropertyName("unopen_rate")]
    public double? UnopenRate { get; set; }

    /// <summary>
    /// The industry unsubscribe rate.
    /// </summary>
    [JsonPropertyName("unsub_rate")]
    public double? UnsubRate { get; set; }

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
