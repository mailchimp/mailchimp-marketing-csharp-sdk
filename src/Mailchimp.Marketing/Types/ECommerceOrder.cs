using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific order.
/// </summary>
[Serializable]
public record ECommerceOrder : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ECommerceOrderLinksItem>? Links { get; set; }

    /// <summary>
    /// The billing address for the order.
    /// </summary>
    [JsonPropertyName("billing_address")]
    public ECommerceOrderBillingAddress? BillingAddress { get; set; }

    /// <summary>
    /// A string that uniquely identifies the campaign associated with an order.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// A cart id that the order was placed for.
    /// </summary>
    [JsonPropertyName("cart_id")]
    public string? CartId { get; set; }

    /// <summary>
    /// The date and time the order was cancelled in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("cancelled_at_foreign")]
    public DateTime? CancelledAtForeign { get; set; }

    /// <summary>
    /// The three-letter ISO 4217 code for the currency that the store accepts.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

    [JsonPropertyName("customer")]
    public ECommerceCustomer? Customer { get; set; }

    /// <summary>
    /// The total amount of the discounts to be applied to the price of the order.
    /// </summary>
    [JsonPropertyName("discount_total")]
    public double? DiscountTotal { get; set; }

    /// <summary>
    /// The order status. Use this parameter to trigger [Order Notifications](https://mailchimp.com/developer/marketing/docs/e-commerce/#order-notifications).
    /// </summary>
    [JsonPropertyName("financial_status")]
    public string? FinancialStatus { get; set; }

    /// <summary>
    /// The fulfillment status for the order. Use this parameter to trigger [Order Notifications](https://mailchimp.com/developer/marketing/docs/e-commerce/#order-notifications).
    /// </summary>
    [JsonPropertyName("fulfillment_status")]
    public string? FulfillmentStatus { get; set; }

    /// <summary>
    /// A unique identifier for the order.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The URL for the page where the buyer landed when entering the shop.
    /// </summary>
    [JsonPropertyName("landing_site")]
    public string? LandingSite { get; set; }

    /// <summary>
    /// An array of the order's line items.
    /// </summary>
    [JsonPropertyName("lines")]
    public IEnumerable<ECommerceOrderLineItem>? Lines { get; set; }

    [JsonPropertyName("order_total")]
    public OneOf<double, string>? OrderTotal { get; set; }

    /// <summary>
    /// The URL for the order.
    /// </summary>
    [JsonPropertyName("order_url")]
    public string? OrderUrl { get; set; }

    /// <summary>
    /// The outreach associated with this order. For example, an email campaign or Facebook ad.
    /// </summary>
    [JsonPropertyName("outreach")]
    public ECommerceOrderOutreach? Outreach { get; set; }

    /// <summary>
    /// The date and time the order was processed in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("processed_at_foreign")]
    public DateTime? ProcessedAtForeign { get; set; }

    /// <summary>
    /// The promo codes applied on the order
    /// </summary>
    [JsonPropertyName("promos")]
    public IEnumerable<ECommerceOrderPromosItem>? Promos { get; set; }

    /// <summary>
    /// The shipping address for the order.
    /// </summary>
    [JsonPropertyName("shipping_address")]
    public ECommerceOrderShippingAddress? ShippingAddress { get; set; }

    [JsonPropertyName("shipping_total")]
    public OneOf<double, string>? ShippingTotal { get; set; }

    /// <summary>
    /// The unique identifier for the store.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("store_id")]
    public string? StoreId { get; set; }

    [JsonPropertyName("tax_total")]
    public OneOf<double, string>? TaxTotal { get; set; }

    /// <summary>
    /// The tracking carrier associated with the order.
    /// </summary>
    [JsonPropertyName("tracking_carrier")]
    public string? TrackingCarrier { get; set; }

    /// <summary>
    /// The Mailchimp tracking code for the order. Uses the 'mc_tc' parameter in E-Commerce tracking URLs.
    /// </summary>
    [JsonPropertyName("tracking_code")]
    public ECommerceOrderTrackingCode? TrackingCode { get; set; }

    /// <summary>
    /// The tracking number associated with the order.
    /// </summary>
    [JsonPropertyName("tracking_number")]
    public string? TrackingNumber { get; set; }

    /// <summary>
    /// The tracking URL associated with the order.
    /// </summary>
    [JsonPropertyName("tracking_url")]
    public string? TrackingUrl { get; set; }

    /// <summary>
    /// The date and time the order was updated in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("updated_at_foreign")]
    public DateTime? UpdatedAtForeign { get; set; }

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
