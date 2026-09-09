using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteBatchesRequest
{
    /// <summary>
    /// The unique id for the batch operation.
    /// </summary>
    [JsonIgnore]
    public required string BatchId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
