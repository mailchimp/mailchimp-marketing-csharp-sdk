using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Configure a webhook for the given list.
/// </summary>
[Serializable]
public record AddWebhook : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The events that can trigger the webhook and whether they are enabled.
    /// </summary>
    [JsonPropertyName("events")]
    public AddWebhookEvents? Events { get; set; }

    /// <summary>
    /// The possible sources of any events that can trigger the webhook and whether they are enabled.
    /// </summary>
    [JsonPropertyName("sources")]
    public AddWebhookSources? Sources { get; set; }

    /// <summary>
    /// A valid URL for the Webhook.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

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
