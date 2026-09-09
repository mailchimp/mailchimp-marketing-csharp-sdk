using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A specific feedback message from a specific campaign.
/// </summary>
[Serializable]
public record CreateFeedbackCampaignsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    public required string Message { get; set; }

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
