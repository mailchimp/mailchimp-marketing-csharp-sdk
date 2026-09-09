using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record UpsertStoreProductEcommerceRequest
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
    /// The description of a product.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The handle of a product.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? Handle { get; set; }

    /// <summary>
    /// A unique identifier for the product.
    /// </summary>
    [JsonPropertyName("id")]
    public required OneOf<string, int> Id { get; set; }

    /// <summary>
    /// The image URL for a product.
    /// </summary>
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    /// <summary>
    /// An array of the product's images.
    /// </summary>
    [JsonPropertyName("images")]
    public IEnumerable<UpsertStoreProductEcommerceRequestImagesItem>? Images { get; set; }

    /// <summary>
    /// The date and time the product was published.
    /// </summary>
    [JsonPropertyName("published_at_foreign")]
    public string? PublishedAtForeign { get; set; }

    /// <summary>
    /// The title of a product.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The type of product.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The URL for a product.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// An array of the product's variants. At least one variant is required for each product. A variant can use the same `id` and `title` as the parent product.
    /// </summary>
    [JsonPropertyName("variants")]
    public IEnumerable<UpsertStoreProductEcommerceRequestVariantsItem>? Variants { get; set; }

    /// <summary>
    /// The vendor for a product.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
