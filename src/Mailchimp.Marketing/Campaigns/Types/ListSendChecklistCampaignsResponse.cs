using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The send checklist for the campaign.
/// </summary>
[Serializable]
public record ListSendChecklistCampaignsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListSendChecklistCampaignsResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// Whether the campaign is ready to send.
    /// </summary>
    [JsonPropertyName("is_ready")]
    public bool? IsReady { get; set; }

    /// <summary>
    /// A list of feedback items to review before sending your campaign.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<ListSendChecklistCampaignsResponseItemsItem>? Items { get; set; }

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
