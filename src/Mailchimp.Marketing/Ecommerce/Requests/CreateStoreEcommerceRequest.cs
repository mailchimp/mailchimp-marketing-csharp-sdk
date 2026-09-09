using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateStoreEcommerceRequest
{
    /// <summary>
    /// The store address.
    /// </summary>
    [JsonPropertyName("address")]
    public CreateStoreEcommerceRequestAddress? Address { get; set; }

    /// <summary>
    /// The three-letter ISO 4217 code for the currency that the store accepts.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; set; }

    /// <summary>
    /// The store domain. This parameter is required for Connected Sites and Google Ads.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// The email address for the store.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The unique identifier for the store.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether to disable automations because the store is currently [syncing](https://mailchimp.com/developer/marketing/docs/e-commerce/#pausing-store-automations).
    /// </summary>
    [JsonPropertyName("is_syncing")]
    public bool? IsSyncing { get; set; }

    /// <summary>
    /// The unique identifier for the list associated with the store. The `list_id` for a specific store cannot change.
    /// </summary>
    [JsonPropertyName("list_id")]
    public required string ListId { get; set; }

    /// <summary>
    /// The currency format for the store. For example: `$`, `£`, etc.
    /// </summary>
    [JsonPropertyName("money_format")]
    public string? MoneyFormat { get; set; }

    /// <summary>
    /// The name of the store.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The store phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    /// <summary>
    /// The e-commerce platform of the store.
    /// </summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// The primary locale for the store. For example: `en`, `de`, etc.
    /// </summary>
    [JsonPropertyName("primary_locale")]
    public string? PrimaryLocale { get; set; }

    /// <summary>
    /// The timezone for the store.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
