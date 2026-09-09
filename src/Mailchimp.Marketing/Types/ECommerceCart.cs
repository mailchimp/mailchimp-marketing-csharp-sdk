using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific cart.
/// </summary>
[Serializable]
public record ECommerceCart : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ECommerceCartLinksItem>? Links { get; set; }

    /// <summary>
    /// A string that uniquely identifies the campaign associated with a cart.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// The URL for the cart. This parameter is required for [Abandoned Cart](https://mailchimp.com/help/create-a-classic-abandoned-cart-email/) automations.
    /// </summary>
    [JsonPropertyName("checkout_url")]
    public string? CheckoutUrl { get; set; }

    /// <summary>
    /// The date and time the cart was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The three-letter ISO 4217 code for the currency that the cart uses.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

    [JsonPropertyName("customer")]
    public ECommerceCustomer? Customer { get; set; }

    /// <summary>
    /// A unique identifier for the cart.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// An array of the cart's line items.
    /// </summary>
    [JsonPropertyName("lines")]
    public IEnumerable<ECommerceCartLineItem>? Lines { get; set; }

    /// <summary>
    /// The order total for the cart.
    /// </summary>
    [JsonPropertyName("order_total")]
    public double? OrderTotal { get; set; }

    /// <summary>
    /// The total tax for the cart.
    /// </summary>
    [JsonPropertyName("tax_total")]
    public double? TaxTotal { get; set; }

    /// <summary>
    /// The date and time the cart was last updated in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

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
