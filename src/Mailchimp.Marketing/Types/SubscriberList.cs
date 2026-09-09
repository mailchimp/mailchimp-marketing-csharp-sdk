using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific list.
/// </summary>
[Serializable]
public record SubscriberList : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<SubscriberListLinksItem>? Links { get; set; }

    /// <summary>
    /// The list's [Email Beamer](https://mailchimp.com/help/use-email-beamer-to-create-a-campaign/) address.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("beamer_address")]
    public string? BeamerAddress { get; set; }

    /// <summary>
    /// [Default values for campaigns](https://mailchimp.com/help/edit-your-emails-subject-preview-text-from-name-or-from-email-address/) created for this list.
    /// </summary>
    [JsonPropertyName("campaign_defaults")]
    public SubscriberListCampaignDefaults? CampaignDefaults { get; set; }

    /// <summary>
    /// [Contact information displayed in campaign footers](https://mailchimp.com/help/about-campaign-footers/) to comply with international spam laws.
    /// </summary>
    [JsonPropertyName("contact")]
    public SubscriberListContact? Contact { get; set; }

    /// <summary>
    /// The date and time that this list was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("date_created")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Whether or not to require the subscriber to confirm subscription via email.
    /// </summary>
    [JsonPropertyName("double_optin")]
    public bool? DoubleOptin { get; set; }

    /// <summary>
    /// Whether the list supports [multiple formats for emails](https://mailchimp.com/help/audience-settings-and-defaults/). When set to `true`, subscribers can choose whether they want to receive HTML or plain-text emails. When set to `false`, subscribers will receive HTML emails, with a plain-text alternative backup.
    /// </summary>
    [JsonPropertyName("email_type_option")]
    public bool? EmailTypeOption { get; set; }

    /// <summary>
    /// Whether or not this list has a welcome automation connected. Welcome Automations: welcomeSeries, singleWelcome, emailFollowup.
    /// </summary>
    [JsonPropertyName("has_welcome")]
    public bool? HasWelcome { get; set; }

    /// <summary>
    /// A string that uniquely identifies this list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// An auto-generated activity score for the list (0-5).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_rating")]
    public int? ListRating { get; set; }

    /// <summary>
    /// Whether or not the list has marketing permissions (eg. GDPR) enabled.
    /// </summary>
    [JsonPropertyName("marketing_permissions")]
    public bool? MarketingPermissions { get; set; }

    /// <summary>
    /// Any list-specific modules installed for this list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modules")]
    public IEnumerable<string>? Modules { get; set; }

    /// <summary>
    /// The name of the list.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The email address to send [subscribe notifications](https://mailchimp.com/help/change-subscribe-and-unsubscribe-notifications/) to.
    /// </summary>
    [JsonPropertyName("notify_on_subscribe")]
    public string? NotifyOnSubscribe { get; set; }

    /// <summary>
    /// The email address to send [unsubscribe notifications](https://mailchimp.com/help/change-subscribe-and-unsubscribe-notifications/) to.
    /// </summary>
    [JsonPropertyName("notify_on_unsubscribe")]
    public string? NotifyOnUnsubscribe { get; set; }

    /// <summary>
    /// The [permission reminder](https://mailchimp.com/help/edit-the-permission-reminder/) for the list.
    /// </summary>
    [JsonPropertyName("permission_reminder")]
    public string? PermissionReminder { get; set; }

    /// <summary>
    /// Stats for the list. Many of these are cached for at least five minutes.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("stats")]
    public SubscriberListStats? Stats { get; set; }

    /// <summary>
    /// The full version of this list's subscribe form (host will vary).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subscribe_url_long")]
    public string? SubscribeUrlLong { get; set; }

    /// <summary>
    /// Our [url shortened](https://mailchimp.com/help/share-your-signup-form/) version of this list's subscribe form.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subscribe_url_short")]
    public string? SubscribeUrlShort { get; set; }

    /// <summary>
    /// Whether campaigns for this list use the [Archive Bar](https://mailchimp.com/help/about-email-campaign-archives-and-pages/) in archives by default.
    /// </summary>
    [JsonPropertyName("use_archive_bar")]
    public bool? UseArchiveBar { get; set; }

    /// <summary>
    /// Legacy - visibility settings are no longer used
    /// </summary>
    [JsonPropertyName("visibility")]
    public SubscriberListVisibility? Visibility { get; set; }

    /// <summary>
    /// The ID used in the Mailchimp web application. View this list in your Mailchimp account at `https://{dc}.admin.mailchimp.com/lists/members/?id={web_id}`.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("web_id")]
    public int? WebId { get; set; }

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
