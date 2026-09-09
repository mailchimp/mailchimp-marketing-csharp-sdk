using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateStoreOrderLineEcommerceRequest
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

    /// <summary>
    /// The id for the line item of an order.
    /// </summary>
    [JsonIgnore]
    public required string LineId { get; set; }

    [JsonPropertyName("discount")]
    public OneOf<double, string>? Discount { get; set; }

    /// <summary>
    /// A unique identifier for the order line item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("price")]
    public OneOf<double, string>? Price { get; set; }

    /// <summary>
    /// A unique identifier for the product associated with the order line item.
    /// </summary>
    [JsonPropertyName("product_id")]
    public string? ProductId { get; set; }

    /// <summary>
    /// A unique identifier for the product variant associated with the order line item.
    /// </summary>
    [JsonPropertyName("product_variant_id")]
    public string? ProductVariantId { get; set; }

    /// <summary>
    /// The quantity of an order line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
