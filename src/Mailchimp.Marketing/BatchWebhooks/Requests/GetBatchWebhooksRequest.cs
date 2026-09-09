using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record GetBatchWebhooksRequest
{
    /// <summary>
    /// The unique id for the batch webhook.
    /// </summary>
    [JsonIgnore]
    public required string BatchWebhookId { get; set; }

    /// <summary>
    /// A comma-separated list of fields to return. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Fields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// A comma-separated list of fields to exclude. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ExcludeFields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
