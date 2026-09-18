using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateBatchWebhooksResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The HMAC signing secret. Returned exactly once at creation. This should be stored securely; if lost, delete and recreate the webhook to obtain a new secret.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("signing_secret")]
    public string? SigningSecret { get; set; }

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<IEnumerable<BatchWebhookLinksItemItem>>? Links { get; set; }

    /// <summary>
    /// Whether the webhook receives requests or not.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// A string that uniquely identifies this Batch Webhook.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether outbound deliveries are HMAC-signed.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("signing_enabled")]
    public bool? SigningEnabled { get; set; }

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
