using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific order line.
/// </summary>
[Serializable]
public record CreateStoreOrderEcommerceRequestLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
