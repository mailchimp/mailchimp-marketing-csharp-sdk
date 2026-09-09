using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific product variant.
/// </summary>
[Serializable]
public record ECommerceProductVariant : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ECommerceProductVariantLinksItem>? Links { get; set; }

    /// <summary>
    /// The backorders of a product variant.
    /// </summary>
    [JsonPropertyName("backorders")]
    public string? Backorders { get; set; }

    /// <summary>
    /// The date and time the product was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// A unique identifier for the product variant.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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

    /// <summary>
    /// The price of a product variant.
    /// </summary>
    [JsonPropertyName("price")]
    public double? Price { get; set; }

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
    /// The date and time the product was last updated in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
