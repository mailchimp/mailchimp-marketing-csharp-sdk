using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateStorePromoRulePromoCodeEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    /// <summary>
    /// The id for the promo rule of a store.
    /// </summary>
    [JsonIgnore]
    public required string PromoRuleId { get; set; }

    /// <summary>
    /// The discount code. Restricted to UTF-8 characters with max length 50.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// The date and time the promotion was created in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("created_at_foreign")]
    public string? CreatedAtForeign { get; set; }

    /// <summary>
    /// Whether the promo code is currently enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// A unique identifier for the promo code. Restricted to UTF-8 characters with max length 50.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The url that should be used in the promotion campaign restricted to UTF-8 characters with max length 2000.
    /// </summary>
    [JsonPropertyName("redemption_url")]
    public required string RedemptionUrl { get; set; }

    /// <summary>
    /// The date and time the promotion was updated in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("updated_at_foreign")]
    public string? UpdatedAtForeign { get; set; }

    /// <summary>
    /// Number of times promo code has been used.
    /// </summary>
    [JsonPropertyName("usage_count")]
    public int? UsageCount { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
