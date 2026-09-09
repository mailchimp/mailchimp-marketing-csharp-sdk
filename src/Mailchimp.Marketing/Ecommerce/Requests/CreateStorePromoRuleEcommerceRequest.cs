using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateStorePromoRuleEcommerceRequest
{
    /// <summary>
    /// The store id.
    /// </summary>
    [JsonIgnore]
    public required string StoreId { get; set; }

    [JsonPropertyName("amount")]
    public required OneOf<double, string> Amount { get; set; }

    /// <summary>
    /// The date and time the promotion was created in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("created_at_foreign")]
    public string? CreatedAtForeign { get; set; }

    /// <summary>
    /// The description of a promotion restricted to UTF-8 characters with max length 255.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// Whether the promo rule is currently enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("ends_at")]
    public OneOf<
        OneOf<DateTime, DateOnly, string>,
        CreateStorePromoRuleEcommerceRequestEndsAtOne
    >? EndsAt { get; set; }

    /// <summary>
    /// A unique identifier for the promo rule. If Ecommerce platform does not support promo rule, use promo code id as promo rule id. Restricted to UTF-8 characters with max length 50.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("starts_at")]
    public OneOf<
        OneOf<DateTime, DateOnly, string>,
        CreateStorePromoRuleEcommerceRequestStartsAtOne
    >? StartsAt { get; set; }

    /// <summary>
    /// The target that the discount applies to.
    /// </summary>
    [JsonPropertyName("target")]
    public required CreateStorePromoRuleEcommerceRequestTarget Target { get; set; }

    /// <summary>
    /// The title that will show up in promotion campaign. Restricted to UTF-8 characters with max length of 100 bytes.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Type of discount. For free shipping set type to fixed.
    /// </summary>
    [JsonPropertyName("type")]
    public required CreateStorePromoRuleEcommerceRequestType Type { get; set; }

    /// <summary>
    /// The date and time the promotion was updated in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("updated_at_foreign")]
    public string? UpdatedAtForeign { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
