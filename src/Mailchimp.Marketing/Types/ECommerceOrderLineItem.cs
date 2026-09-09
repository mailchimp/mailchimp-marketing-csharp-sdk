using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific order line.
/// </summary>
[Serializable]
public record ECommerceOrderLineItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ECommerceOrderLineItemLinksItem>? Links { get; set; }

    /// <summary>
    /// The total discount amount applied to a line item.
    /// </summary>
    [JsonPropertyName("discount")]
    public double? Discount { get; set; }

    /// <summary>
    /// A unique identifier for an order line item.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The image URL for a product.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    [JsonPropertyName("price")]
    public OneOf<double, string>? Price { get; set; }

    /// <summary>
    /// A unique identifier for the product associated with an order line item.
    /// </summary>
    [JsonPropertyName("product_id")]
    public string? ProductId { get; set; }

    /// <summary>
    /// The name of the product for an order line item.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("product_title")]
    public string? ProductTitle { get; set; }

    /// <summary>
    /// A unique identifier for the product variant associated with an order line item.
    /// </summary>
    [JsonPropertyName("product_variant_id")]
    public string? ProductVariantId { get; set; }

    /// <summary>
    /// The name of the product variant for an order line item.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("product_variant_title")]
    public string? ProductVariantTitle { get; set; }

    /// <summary>
    /// The order line item quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

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
