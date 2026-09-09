using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateStoreOrderLineEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// The id for the order in a store.
    /// </summary>
    [JsonIgnore]
    public required string OrderId { get; set; }

    [JsonPropertyName("discount")]
    public OneOf<double, string>? Discount { get; set; }

    /// <summary>
    /// A unique identifier for the order line item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("price")]
    public required OneOf<double, string> Price { get; set; }

    [JsonPropertyName("product")]
    public EcommerceStoresOrdersPost? Product { get; set; }

    /// <summary>
    /// A unique identifier for the product associated with the order line item.
    /// </summary>
    [JsonPropertyName("product_id")]
    public required string ProductId { get; set; }

    /// <summary>
    /// A unique identifier for the product variant associated with the order line item.
    /// </summary>
    [JsonPropertyName("product_variant_id")]
    public required string ProductVariantId { get; set; }

    /// <summary>
    /// The quantity of an order line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required int Quantity { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
