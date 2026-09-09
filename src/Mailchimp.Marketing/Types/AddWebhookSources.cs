using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The possible sources of any events that can trigger the webhook and whether they are enabled.
/// </summary>
[Serializable]
public record AddWebhookSources : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the webhook is triggered by admin-initiated actions in the web interface.
    /// </summary>
    [JsonPropertyName("admin")]
    public bool? Admin { get; set; }

    /// <summary>
    /// Whether the webhook is triggered by actions initiated via the API.
    /// </summary>
    [JsonPropertyName("api")]
    public bool? Api { get; set; }

    /// <summary>
    /// Whether the webhook is triggered by subscriber-initiated actions.
    /// </summary>
    [JsonPropertyName("user")]
    public bool? User { get; set; }

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
