using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateBatchWebhooksRequest
{
    /// <summary>
    /// The unique id for the batch webhook.
    /// </summary>
    [JsonIgnore]
    public required string BatchWebhookId { get; set; }

    /// <summary>
    /// Whether the webhook receives requests or not.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// A valid URL for the Webhook.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
