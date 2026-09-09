using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateStoreCartEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// A string that uniquely identifies the campaign for a cart.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// The URL for the cart. This parameter is required for [Abandoned Cart](https://mailchimp.com/help/create-a-classic-abandoned-cart-email/) automations.
    /// </summary>
    [JsonPropertyName("checkout_url")]
    public string? CheckoutUrl { get; set; }

    /// <summary>
    /// The three-letter ISO 4217 code for the currency that the cart uses.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; set; }

    [JsonPropertyName("customer")]
    public required EcommerceStoresCartsPost Customer { get; set; }

    /// <summary>
    /// A unique identifier for the cart.
    /// </summary>
    [JsonPropertyName("id")]
    public required OneOf<string, int> Id { get; set; }

    /// <summary>
    /// An array of the cart's line items.
    /// </summary>
    [JsonPropertyName("lines")]
    public IEnumerable<CreateStoreCartEcommerceRequestLinesItem> Lines { get; set; } =
        new global::System.Collections.Generic.List<CreateStoreCartEcommerceRequestLinesItem>();

    [JsonPropertyName("order_total")]
    public required OneOf<double, string> OrderTotal { get; set; }

    [JsonPropertyName("tax_total")]
    public OneOf<double, string>? TaxTotal { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
