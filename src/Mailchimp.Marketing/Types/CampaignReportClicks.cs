using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An object describing the click activity for the campaign.
/// </summary>
[Serializable]
public record CampaignReportClicks : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of unique clicks divided by the total number of successful deliveries.
    /// </summary>
    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    /// <summary>
    /// The total number of clicks for the campaign.
    /// </summary>
    [JsonPropertyName("clicks_total")]
    public int? ClicksTotal { get; set; }

    /// <summary>
    /// The date and time of the last recorded click for the campaign in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// The total number of unique clicks for links across a campaign.
    /// </summary>
    [JsonPropertyName("unique_clicks")]
    public int? UniqueClicks { get; set; }

    /// <summary>
    /// The total number of subscribers who clicked on a campaign.
    /// </summary>
    [JsonPropertyName("unique_subscriber_clicks")]
    public int? UniqueSubscriberClicks { get; set; }

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
