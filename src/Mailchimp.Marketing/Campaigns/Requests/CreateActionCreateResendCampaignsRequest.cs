using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateActionCreateResendCampaignsRequest
{
    /// <summary>
    /// The unique id for the campaign.
    /// </summary>
    [JsonIgnore]
    public required string CampaignId { get; set; }

    /// <summary>
    /// Which campaign resend shortcut to use. Default is `to_non_openers`.
    /// </summary>
    [JsonPropertyName("shortcut_type")]
    public CreateActionCreateResendCampaignsRequestShortcutType? ShortcutType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
