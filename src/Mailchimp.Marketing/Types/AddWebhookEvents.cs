using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The events that can trigger the webhook and whether they are enabled.
/// </summary>
[Serializable]
public record AddWebhookEvents : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the webhook is triggered when a campaign is sent or cancelled.
    /// </summary>
    [JsonPropertyName("campaign")]
    public bool? Campaign { get; set; }

    /// <summary>
    /// Whether the webhook is triggered when a subscriber's email address is cleaned from the list.
    /// </summary>
    [JsonPropertyName("cleaned")]
    public bool? Cleaned { get; set; }

    /// <summary>
    /// Whether the webhook is triggered when a contact's profile is updated. This includes email subscribers and SMS-only contacts [BETA].
    /// </summary>
    [JsonPropertyName("profile")]
    public bool? Profile { get; set; }

    /// <summary>
    /// Whether the webhook is triggered when a list subscriber is added.
    /// </summary>
    [JsonPropertyName("subscribe")]
    public bool? Subscribe { get; set; }

    /// <summary>
    /// Whether the webhook is triggered when a list member unsubscribes.
    /// </summary>
    [JsonPropertyName("unsubscribe")]
    public bool? Unsubscribe { get; set; }

    /// <summary>
    /// Whether the webhook is triggered when a subscriber's email address is changed.
    /// </summary>
    [JsonPropertyName("upemail")]
    public bool? Upemail { get; set; }

    /// <summary>
    /// [BETA] Whether the webhook is triggered when a contact subscribes to SMS.
    /// </summary>
    [JsonPropertyName("sms_subscribe")]
    public bool? SmsSubscribe { get; set; }

    /// <summary>
    /// [BETA] Whether the webhook is triggered when a contact unsubscribes from SMS.
    /// </summary>
    [JsonPropertyName("sms_unsubscribe")]
    public bool? SmsUnsubscribe { get; set; }

    /// <summary>
    /// [BETA] Whether the webhook is triggered when a contact's SMS phone number is updated.
    /// </summary>
    [JsonPropertyName("upsms")]
    public bool? Upsms { get; set; }

    /// <summary>
    /// [BETA] Whether the webhook is triggered when an SMS campaign is sent.
    /// </summary>
    [JsonPropertyName("sms_campaign")]
    public bool? SmsCampaign { get; set; }

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
