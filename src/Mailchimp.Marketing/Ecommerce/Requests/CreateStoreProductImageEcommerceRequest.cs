using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateStoreProductImageEcommerceRequest
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
    /// A unique identifier for the product image.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The URL for a product image.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// The list of product variants using the image.
    /// </summary>
    [JsonPropertyName("variant_ids")]
    public IEnumerable<OneOf<string, int>>? VariantIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
