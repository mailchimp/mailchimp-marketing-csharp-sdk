using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// [Default values for campaigns](https://mailchimp.com/help/edit-your-emails-subject-preview-text-from-name-or-from-email-address/) created for this list.
    /// </summary>
    [JsonPropertyName("campaign_defaults")]
    public UpdateListsRequestCampaignDefaults? CampaignDefaults { get; set; }

    /// <summary>
    /// [Contact information displayed in campaign footers](https://mailchimp.com/help/about-campaign-footers/) to comply with international spam laws.
    /// </summary>
    [JsonPropertyName("contact")]
    public UpdateListsRequestContact? Contact { get; set; }

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
    /// Whether or not the list has marketing permissions (eg. GDPR) enabled.
    /// </summary>
    [JsonPropertyName("marketing_permissions")]
    public bool? MarketingPermissions { get; set; }

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
    /// Whether campaigns for this list use the [Archive Bar](https://mailchimp.com/help/about-email-campaign-archives-and-pages/) in archives by default.
    /// </summary>
    [JsonPropertyName("use_archive_bar")]
    public bool? UseArchiveBar { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
