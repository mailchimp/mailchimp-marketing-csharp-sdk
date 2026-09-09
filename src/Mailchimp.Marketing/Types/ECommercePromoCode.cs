using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about an Ecommerce Store's specific Promo Code
/// </summary>
[Serializable]
public record ECommercePromoCode : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ECommercePromoCodeLinksItem>? Links { get; set; }

    /// <summary>
    /// The discount code. Restricted to UTF-8 characters with max length 50.
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// The date and time the promotion was created in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("created_at_foreign")]
    public DateTime? CreatedAtForeign { get; set; }

    /// <summary>
    /// Whether the promo code is currently enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// A unique identifier for the promo Code.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The url that should be used in the promotion campaign restricted to UTF-8 characters with max length 2000.
    /// </summary>
    [JsonPropertyName("redemption_url")]
    public string? RedemptionUrl { get; set; }

    /// <summary>
    /// The date and time the promotion was updated in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("updated_at_foreign")]
    public DateTime? UpdatedAtForeign { get; set; }

    /// <summary>
    /// Number of times promo code has been used.
    /// </summary>
    [JsonPropertyName("usage_count")]
    public int? UsageCount { get; set; }

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
