using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record AudiencesContactEmailChannel : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A computation performed by the Mailchimp platform, triggered whenever any of its inputs change. Some inputs are controlled by API users, while others are tracked internally by the platform. Computation is based on: audience opt-in configuration (single vs. double opt-in), marketing consent status, and deliverability status (an internal state for a contact, maintained by Mailchimp for a specific marketing channel instance). This new API field is distinct from how contacts are displayed in the UI. See the [Audiences (BETA) documentation](https://mailchimp.com/developer/marketing/docs/audiences-introduction) to learn about supported values.
    /// </summary>
    [JsonPropertyName("effective_subscription_status")]
    public AudiencesContactEmailChannelEffectiveSubscriptionStatus? EffectiveSubscriptionStatus { get; set; }

    /// <summary>
    /// Email address
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// MD5 hash of the email address
    /// </summary>
    [JsonPropertyName("hashed_email")]
    public string? HashedEmail { get; set; }

    /// <summary>
    /// A contact's current consent status for email marketing communications. See the [Audiences (BETA) documentation](https://mailchimp.com/developer/marketing/docs/audiences-introduction) to learn about supported values.
    /// </summary>
    [JsonPropertyName("marketing_consent")]
    public AudiencesContactEmailChannelMarketingConsent? MarketingConsent { get; set; }

    /// <summary>
    /// The source from which the parent's entity was created.
    /// </summary>
    [JsonPropertyName("source")]
    public AudiencesContactEmailChannelSource? Source { get; set; }

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
