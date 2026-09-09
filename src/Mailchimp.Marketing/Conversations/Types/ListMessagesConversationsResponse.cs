using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Messages from a specific conversation.
/// </summary>
[Serializable]
public record ListMessagesConversationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListMessagesConversationsResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// A string that identifies this conversation.
    /// </summary>
    [JsonPropertyName("conversation_id")]
    public string? ConversationId { get; set; }

    /// <summary>
    /// An array of objects, each representing a conversation messages resources.
    /// </summary>
    [JsonPropertyName("conversation_messages")]
    public IEnumerable<ConversationMessage>? ConversationMessages { get; set; }

    /// <summary>
    /// The total number of items matching the query regardless of pagination.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_items")]
    public int? TotalItems { get; set; }

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
