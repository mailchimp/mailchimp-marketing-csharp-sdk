using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateStoreCartLineEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// The id for the cart.
    /// </summary>
    [JsonIgnore]
    public required string CartId { get; set; }

    /// <summary>
    /// The id for the line item of a cart.
    /// </summary>
    [JsonIgnore]
    public required string LineId { get; set; }

    [JsonPropertyName("price")]
    public OneOf<double, string>? Price { get; set; }

    /// <summary>
    /// A unique identifier for the product associated with the cart line item.
    /// </summary>
    [JsonPropertyName("product_id")]
    public string? ProductId { get; set; }

    /// <summary>
    /// A unique identifier for the product variant associated with the cart line item.
    /// </summary>
    [JsonPropertyName("product_variant_id")]
    public string? ProductVariantId { get; set; }

    /// <summary>
    /// The quantity of a cart line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
