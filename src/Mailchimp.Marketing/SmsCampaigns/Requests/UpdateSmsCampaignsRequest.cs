using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateSmsCampaignsRequest
{
    /// <summary>
    /// The unique id for the SMS campaign.
    /// </summary>
    [JsonIgnore]
    public required string SmsCampaignId { get; set; }

    /// <summary>
    /// The name of the campaign.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the folder to place this campaign in.
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string? FolderId { get; set; }

    /// <summary>
    /// The segment IDs to target for this campaign.
    /// </summary>
    [JsonPropertyName("segments")]
    public IEnumerable<int>? Segments { get; set; }

    /// <summary>
    /// The segment IDs to exclude from this campaign.
    /// </summary>
    [JsonPropertyName("excluded_segments")]
    public IEnumerable<int>? ExcludedSegments { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
