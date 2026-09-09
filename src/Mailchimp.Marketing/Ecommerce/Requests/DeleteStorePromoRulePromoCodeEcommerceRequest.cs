using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteStorePromoRulePromoCodeEcommerceRequest
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
    /// The id for the promo code of a store.
    /// </summary>
    [JsonIgnore]
    public required string PromoCodeId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
