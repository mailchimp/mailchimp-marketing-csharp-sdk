using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteBatchWebhooksRequest
{
    /// <summary>
    /// The unique id for the batch webhook.
    /// </summary>
    [JsonIgnore]
    public required string BatchWebhookId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
