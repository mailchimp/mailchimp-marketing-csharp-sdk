using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A single email domain's performance
/// </summary>
[Serializable]
public record ListDomainPerformanceReportsResponseDomainsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of bounces at a domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("bounces")]
    public int? Bounces { get; set; }

    /// <summary>
    /// The percentage of total bounces from this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("bounces_pct")]
    public double? BouncesPct { get; set; }

    /// <summary>
    /// The number of clicks for a domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    /// <summary>
    /// The percentage of total clicks from this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("clicks_pct")]
    public double? ClicksPct { get; set; }

    /// <summary>
    /// The number of successful deliveries for a domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("delivered")]
    public int? Delivered { get; set; }

    /// <summary>
    /// The name of the domain (gmail.com, hotmail.com, yahoo.com).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// The percentage of total emails that went to this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("emails_pct")]
    public double? EmailsPct { get; set; }

    /// <summary>
    /// The number of emails sent to that specific domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// The number of opens for a domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("opens")]
    public int? Opens { get; set; }

    /// <summary>
    /// The percentage of total opens from this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("opens_pct")]
    public double? OpensPct { get; set; }

    /// <summary>
    /// The total number of unsubscribes for a domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unsubs")]
    public int? Unsubs { get; set; }

    /// <summary>
    /// The percentage of total unsubscribes from this domain.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unsubs_pct")]
    public double? UnsubsPct { get; set; }

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
