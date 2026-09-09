using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpsertContentSmsCampaignsRequest
{
    /// <summary>
    /// The unique id for the SMS campaign.
    /// </summary>
    [JsonIgnore]
    public required string SmsCampaignId { get; set; }

    /// <summary>
    /// The SMS message body.
    /// </summary>
    [JsonPropertyName("message_body")]
    public required string MessageBody { get; set; }

    /// <summary>
    /// Attached images or files. Limited to one item. Omitting this field or sending an empty array removes any existing media; to keep the current media while updating other fields, re-send the media array.
    /// </summary>
    [JsonPropertyName("media")]
    public IEnumerable<UpsertContentSmsCampaignsRequestMediaItem>? Media { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
