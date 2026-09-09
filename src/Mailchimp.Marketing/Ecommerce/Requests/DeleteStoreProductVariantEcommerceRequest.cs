using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteStoreProductVariantEcommerceRequest
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

    /// <summary>
    /// The id for the product variant.
    /// </summary>
    [JsonIgnore]
    public required string VariantId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
