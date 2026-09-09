using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific cart line item.
/// </summary>
[Serializable]
public record ECommerceCartLineItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ECommerceCartLineItemLinksItem>? Links { get; set; }

    /// <summary>
    /// A unique identifier for the cart line item.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The price of a cart line item.
    /// </summary>
    [JsonPropertyName("price")]
    public double? Price { get; set; }

    /// <summary>
    /// A unique identifier for the product associated with the cart line item.
    /// </summary>
    [JsonPropertyName("product_id")]
    public string? ProductId { get; set; }

    /// <summary>
    /// The name of the product for the cart line item.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("product_title")]
    public string? ProductTitle { get; set; }

    /// <summary>
    /// A unique identifier for the product variant associated with the cart line item.
    /// </summary>
    [JsonPropertyName("product_variant_id")]
    public string? ProductVariantId { get; set; }

    /// <summary>
    /// The name of the product variant for the cart line item.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("product_variant_title")]
    public string? ProductVariantTitle { get; set; }

    /// <summary>
    /// The quantity of a cart line item.
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
