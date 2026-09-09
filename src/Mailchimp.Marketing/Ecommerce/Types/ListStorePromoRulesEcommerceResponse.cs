using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A collection of the store's promo rules.
/// </summary>
[Serializable]
public record ListStorePromoRulesEcommerceResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListStorePromoRulesEcommerceResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// An array of objects, each representing promo rules defined for a store.
    /// </summary>
    [JsonPropertyName("promo_rules")]
    public IEnumerable<ECommercePromoRule>? PromoRules { get; set; }

    /// <summary>
    /// The store id.
    /// </summary>
    [JsonPropertyName("store_id")]
    public string? StoreId { get; set; }

    /// <summary>
    /// The total number of items matching the query regardless of pagination.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_items")]
    public int? TotalItems { get; set; }

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
