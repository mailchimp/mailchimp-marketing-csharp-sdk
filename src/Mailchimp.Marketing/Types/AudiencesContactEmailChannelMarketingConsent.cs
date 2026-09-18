using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A contact's current consent status for email marketing communications. See the [Audiences (BETA) documentation](https://mailchimp.com/developer/marketing/docs/audiences-introduction) to learn about supported values.
/// </summary>
[Serializable]
public record AudiencesContactEmailChannelMarketingConsent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The source from which the parent's entity was created.
    /// </summary>
    [JsonPropertyName("source")]
    public AudiencesContactEmailChannelMarketingConsentSource? Source { get; set; }

    [JsonPropertyName("status")]
    public AudiencesContactEmailChannelMarketingConsentStatus? Status { get; set; }

    /// <summary>
    /// The ISO 8601 timestamp when the email marketing consent state was recorded; accepted and returned only when status is `confirmed` or `consented`; defaults to the current time if omitted; ignored if older than an existing stored timestamp (staleness guard).
    /// </summary>
    [JsonPropertyName("captured_at")]
    public DateTime? CapturedAt { get; set; }

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
