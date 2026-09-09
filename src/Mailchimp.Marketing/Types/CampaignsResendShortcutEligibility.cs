using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Determines if the campaign qualifies for the Campaign Resend Shortcuts. Only included when query parameter `include_resend_shortcuts` is `true`.
/// </summary>
[Serializable]
public record CampaignsResendShortcutEligibility : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Determines if the campaign qualifies to be resent to new subscribers.
    /// </summary>
    [JsonPropertyName("to_new_subscribers")]
    public CampaignsResendShortcutEligibilityToNewSubscribers? ToNewSubscribers { get; set; }

    /// <summary>
    /// Determines if the campaign qualifies to be resent to non-clickers.
    /// </summary>
    [JsonPropertyName("to_non_clickers")]
    public CampaignsResendShortcutEligibilityToNonClickers? ToNonClickers { get; set; }

    /// <summary>
    /// Determines if the campaign qualifies to be resent to non-openers.
    /// </summary>
    [JsonPropertyName("to_non_openers")]
    public CampaignsResendShortcutEligibilityToNonOpeners? ToNonOpeners { get; set; }

    /// <summary>
    /// Determines if the campaign qualifies to be resent to non-purchasers.
    /// </summary>
    [JsonPropertyName("to_non_purchasers")]
    public CampaignsResendShortcutEligibilityToNonPurchasers? ToNonPurchasers { get; set; }

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
