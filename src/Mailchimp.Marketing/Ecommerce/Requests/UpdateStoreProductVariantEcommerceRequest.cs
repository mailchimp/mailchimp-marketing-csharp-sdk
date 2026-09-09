using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateStoreProductVariantEcommerceRequest
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

    /// <summary>
    /// The backorders of a product variant.
    /// </summary>
    [JsonPropertyName("backorders")]
    public string? Backorders { get; set; }

    /// <summary>
    /// The image URL for a product variant.
    /// </summary>
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// The inventory quantity of a product variant.
    /// </summary>
    [JsonPropertyName("inventory_quantity")]
    public int? InventoryQuantity { get; set; }

    [JsonPropertyName("price")]
    public OneOf<double, string>? Price { get; set; }

    /// <summary>
    /// The stock keeping unit (SKU) of a product variant.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>
    /// The title of a product variant.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The URL for a product variant.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The visibility of a product variant.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
