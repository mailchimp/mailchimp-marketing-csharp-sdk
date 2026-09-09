using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteCampaignsRequest
{
    /// <summary>
    /// The unique id for the campaign.
    /// </summary>
    [JsonIgnore]
    public required string CampaignId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
