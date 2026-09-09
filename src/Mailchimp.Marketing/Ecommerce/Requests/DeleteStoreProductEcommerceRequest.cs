using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteStoreProductEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// The id for the product of a store.
    /// </summary>
    [JsonIgnore]
    public required string ProductId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
