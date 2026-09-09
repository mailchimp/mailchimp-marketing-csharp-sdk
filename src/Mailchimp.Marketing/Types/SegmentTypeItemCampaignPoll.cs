using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by poll activity.
/// </summary>
[Serializable]
public record SegmentTypeItemCampaignPoll : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by poll activity.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemCampaignPollField Field { get; set; }

    /// <summary>
    /// Members have/have not interacted with a specific poll in a Mailchimp email.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemCampaignPollOp Op { get; set; }

    /// <summary>
    /// The id for the poll.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

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
