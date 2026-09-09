using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// List settings for the Automation.
/// </summary>
[Serializable]
public record AutomationWorkflowRecipients : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// The status of the list used, namely if it's deleted or disabled.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_is_active")]
    public bool? ListIsActive { get; set; }

    /// <summary>
    /// List Name.
    /// </summary>
    [JsonPropertyName("list_name")]
    public string? ListName { get; set; }

    [JsonPropertyName("segment_opts")]
    public IEnumerable<SegmentTypeItem>? SegmentOpts { get; set; }

    /// <summary>
    /// The id of the store.
    /// </summary>
    [JsonPropertyName("store_id")]
    public string? StoreId { get; set; }

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
