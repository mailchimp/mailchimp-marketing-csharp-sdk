using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A contact's current consent status for SMS marketing communications. See the [Audiences (BETA) documentation](https://mailchimp.com/developer/marketing/docs/audiences-introduction) to learn about supported values.
/// </summary>
[Serializable]
public record CreateAudienceContactRequestSmsChannelMarketingConsent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The source from which the parent's entity was created.
    /// </summary>
    [JsonPropertyName("source")]
    public CreateAudienceContactRequestSmsChannelMarketingConsentSource? Source { get; set; }

    /// <summary>
    /// The contact's SMS marketing consent status. Use `confirmed` for double opt-in audiences, `consented` for single opt-in audiences.
    /// </summary>
    [JsonPropertyName("status")]
    public CreateAudienceContactRequestSmsChannelMarketingConsentStatus? Status { get; set; }

    /// <summary>
    /// The timestamp when SMS marketing consent was captured (ISO 8601). Only accepted and returned when status is `confirmed`. The timestamp of the consent state change being recorded. Defaults to the current time if not provided. If the contact already has a consent timestamp on record that is equal to or newer than the supplied value, the supplied value is ignored (staleness guard); to update the consent timestamp supply a value strictly newer than the stored one.
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
