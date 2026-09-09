using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about campaigns related through shortcuts.
/// </summary>
[Serializable]
public record CampaignsResendShortcutUsage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The original campaign that was resent.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("original_campaign")]
    public CampaignsResendShortcutUsageOriginalCampaign? OriginalCampaign { get; set; }

    /// <summary>
    /// Campaigns that were created from Campaign Resend Shortcuts for this campaign
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("shortcut_campaigns")]
    public IEnumerable<CampaignsResendShortcutUsageShortcutCampaignsItem>? ShortcutCampaigns { get; set; }

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
