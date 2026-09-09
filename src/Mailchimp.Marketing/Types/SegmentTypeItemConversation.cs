using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by interaction with a campaign via Conversations.
/// </summary>
[Serializable]
public record SegmentTypeItemConversation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by interaction with a campaign via Conversations.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemConversationField Field { get; set; }

    /// <summary>
    /// The status of a member's interaction with a conversation. One of the following: has replied or has not replied.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemConversationOp Op { get; set; }

    /// <summary>
    /// The web id value for a specific campaign or 'any' to account for subscribers who have/have not interacted with any campaigns.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
