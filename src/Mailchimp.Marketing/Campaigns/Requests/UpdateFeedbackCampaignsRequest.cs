using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateFeedbackCampaignsRequest
{
    /// <summary>
    /// The unique id for the campaign.
    /// </summary>
    [JsonIgnore]
    public required string CampaignId { get; set; }

    /// <summary>
    /// The unique id for the feedback message.
    /// </summary>
    [JsonIgnore]
    public required string FeedbackId { get; set; }

    /// <summary>
    /// The block id for the editable block that the feedback addresses.
    /// </summary>
    [JsonPropertyName("block_id")]
    public int? BlockId { get; set; }

    /// <summary>
    /// The status of feedback.
    /// </summary>
    [JsonPropertyName("is_complete")]
    public bool? IsComplete { get; set; }

    /// <summary>
    /// The content of the feedback.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
