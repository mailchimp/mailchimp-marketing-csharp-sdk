using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateActionSendSmsCampaignsRequest
{
    /// <summary>
    /// The unique id for the SMS campaign.
    /// </summary>
    [JsonIgnore]
    public required string SmsCampaignId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
