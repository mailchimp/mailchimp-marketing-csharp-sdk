using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about an Ecommerce Store's specific Promo Rule
/// </summary>
[Serializable]
public record ECommercePromoRule : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ECommercePromoRuleLinksItem>? Links { get; set; }

    /// <summary>
    /// The amount of the promo code discount. If 'type' is 'fixed', the amount is treated as a monetary value. If 'type' is 'percentage', amount must be a decimal value between 0.0 and 1.0, inclusive.
    /// </summary>
    [JsonPropertyName("amount")]
    public float? Amount { get; set; }

    /// <summary>
    /// The date and time the promotion was created in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("created_at_foreign")]
    public DateTime? CreatedAtForeign { get; set; }

    /// <summary>
    /// The description of a promotion restricted to UTF-8 characters with max length 255.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Whether the promo rule is currently enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The date and time when the promotion ends. Must be after starts_at and in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("ends_at")]
    public string? EndsAt { get; set; }

    /// <summary>
    /// A unique identifier for the promo rule. If Ecommerce platform does not support promo rule, use promo code id as promo rule id. Restricted to UTF-8 characters with max length 50.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The date and time when the promotion is in effect in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("starts_at")]
    public DateTime? StartsAt { get; set; }

    /// <summary>
    /// The target that the discount applies to.
    /// </summary>
    [JsonPropertyName("target")]
    public ECommercePromoRuleTarget? Target { get; set; }

    /// <summary>
    /// The title that will show up in promotion campaign. Restricted to UTF-8 characters with max length of 100 bytes.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Type of discount. For free shipping set type to fixed.
    /// </summary>
    [JsonPropertyName("type")]
    public ECommercePromoRuleType? Type { get; set; }

    /// <summary>
    /// The date and time the promotion was updated in ISO 8601 format.
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
