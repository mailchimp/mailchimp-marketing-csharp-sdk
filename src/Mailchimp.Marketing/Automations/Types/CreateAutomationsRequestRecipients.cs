using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// List settings for the Automation.
/// </summary>
[Serializable]
public record CreateAutomationsRequestRecipients : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The id of the List.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

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
