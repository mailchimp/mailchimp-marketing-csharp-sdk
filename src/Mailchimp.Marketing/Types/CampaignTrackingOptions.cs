using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The tracking options for a campaign.
/// </summary>
[Serializable]
public record CampaignTrackingOptions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Deprecated
    /// </summary>
    [JsonPropertyName("capsule")]
    public CampaignTrackingOptionsCapsule? Capsule { get; set; }

    /// <summary>
    /// The custom slug for [ClickTale](https://mailchimp.com/help/additional-tracking-options-for-campaigns/) tracking (max of 50 bytes).
    /// </summary>
    [JsonPropertyName("clicktale")]
    public string? Clicktale { get; set; }

    /// <summary>
    /// Whether to enable e-commerce tracking.
    /// </summary>
    [JsonPropertyName("ecomm360")]
    public bool? Ecomm360 { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    [JsonPropertyName("goal_tracking")]
    public bool? GoalTracking { get; set; }

    /// <summary>
    /// The custom slug for [Google Analytics](https://mailchimp.com/help/integrate-google-analytics-with-mailchimp/) tracking (max of 50 bytes).
    /// </summary>
    [JsonPropertyName("google_analytics")]
    public string? GoogleAnalytics { get; set; }

    /// <summary>
    /// Whether to [track clicks](https://mailchimp.com/help/enable-and-view-click-tracking/) in the HTML version of the campaign. Defaults to `true`. Cannot be set to false for variate campaigns.
    /// </summary>
    [JsonPropertyName("html_clicks")]
    public bool? HtmlClicks { get; set; }

    /// <summary>
    /// Whether to [track opens](https://mailchimp.com/help/about-open-tracking/). Defaults to `true`. Cannot be set to false for variate campaigns.
    /// </summary>
    [JsonPropertyName("opens")]
    public bool? Opens { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    [JsonPropertyName("salesforce")]
    public CampaignTrackingOptionsSalesforce? Salesforce { get; set; }

    /// <summary>
    /// Whether to [track clicks](https://mailchimp.com/help/enable-and-view-click-tracking/) in the plain-text version of the campaign. Defaults to `true`. Cannot be set to false for variate campaigns.
    /// </summary>
    [JsonPropertyName("text_clicks")]
    public bool? TextClicks { get; set; }

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
