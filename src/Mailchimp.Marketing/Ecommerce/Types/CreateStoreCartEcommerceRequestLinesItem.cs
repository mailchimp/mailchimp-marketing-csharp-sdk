using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific cart line item.
/// </summary>
[Serializable]
public record CreateStoreCartEcommerceRequestLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A unique identifier for the cart line item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("price")]
    public required OneOf<double, string> Price { get; set; }

    /// <summary>
    /// A unique identifier for the product associated with the cart line item.
    /// </summary>
    [JsonPropertyName("product_id")]
    public required string ProductId { get; set; }

    /// <summary>
    /// A unique identifier for the product variant associated with the cart line item.
    /// </summary>
    [JsonPropertyName("product_variant_id")]
    public required string ProductVariantId { get; set; }

    /// <summary>
    /// The quantity of a cart line item.
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
