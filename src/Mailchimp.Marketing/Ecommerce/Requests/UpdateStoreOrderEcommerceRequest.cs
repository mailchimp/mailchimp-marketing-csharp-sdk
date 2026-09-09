using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateStoreOrderEcommerceRequest
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
    /// The billing address for the order.
    /// </summary>
    [JsonPropertyName("billing_address")]
    public UpdateStoreOrderEcommerceRequestBillingAddress? BillingAddress { get; set; }

    /// <summary>
    /// A string that uniquely identifies the campaign associated with an order.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// A cart id that the order was placed for.
    /// </summary>
    [JsonPropertyName("cart_id")]
    public OneOf<string, int>? CartId { get; set; }

    /// <summary>
    /// The date and time the order was cancelled in ISO 8601 format. Note: passing a value for this parameter will cancel the order being edited.
    /// </summary>
    [JsonPropertyName("cancelled_at_foreign")]
    public string? CancelledAtForeign { get; set; }

    /// <summary>
    /// The three-letter ISO 4217 code for the currency that the store accepts.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

    [JsonPropertyName("customer")]
    public EcommerceStoresCartsPatch? Customer { get; set; }

    [JsonPropertyName("discount_total")]
    public OneOf<double, string>? DiscountTotal { get; set; }

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
    public IEnumerable<UpdateStoreOrderEcommerceRequestLinesItem>? Lines { get; set; }

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
    public UpdateStoreOrderEcommerceRequestOutreach? Outreach { get; set; }

    /// <summary>
    /// The date and time the order was processed in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("processed_at_foreign")]
    public string? ProcessedAtForeign { get; set; }

    /// <summary>
    /// The promo codes applied on the order. Note: Patch will completely replace the value of promos with the new one provided.
    /// </summary>
    [JsonPropertyName("promos")]
    public IEnumerable<UpdateStoreOrderEcommerceRequestPromosItem>? Promos { get; set; }

    /// <summary>
    /// The shipping address for the order.
    /// </summary>
    [JsonPropertyName("shipping_address")]
    public UpdateStoreOrderEcommerceRequestShippingAddress? ShippingAddress { get; set; }

    [JsonPropertyName("shipping_total")]
    public OneOf<double, string>? ShippingTotal { get; set; }

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
    public UpdateStoreOrderEcommerceRequestTrackingCode? TrackingCode { get; set; }

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
    public string? UpdatedAtForeign { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
