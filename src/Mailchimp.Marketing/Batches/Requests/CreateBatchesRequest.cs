using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateBatchesRequest
{
    /// <summary>
    /// An array of objects that describes operations to perform.
    /// </summary>
    [JsonPropertyName("operations")]
    public IEnumerable<CreateBatchesRequestOperationsItem> Operations { get; set; } =
        new global::System.Collections.Generic.List<CreateBatchesRequestOperationsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
