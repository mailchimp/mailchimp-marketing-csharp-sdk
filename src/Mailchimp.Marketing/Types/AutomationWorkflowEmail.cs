using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A summary of an individual Automation workflow email.
/// </summary>
[Serializable]
public record AutomationWorkflowEmail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<AutomationWorkflowEmailLinksItem>? Links { get; set; }

    /// <summary>
    /// The link to the campaign's archive version in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("archive_url")]
    public string? ArchiveUrl { get; set; }

    /// <summary>
    /// How the campaign's content is put together ('template', 'drag_and_drop', 'html', 'url').
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("content_type")]
    public string? ContentType { get; set; }

    /// <summary>
    /// The date and time the campaign was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// The delay settings for an Automation email.
    /// </summary>
    [JsonPropertyName("delay")]
    public AutomationWorkflowEmailDelay? Delay { get; set; }

    /// <summary>
    /// The total number of emails sent for this campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// Determines if the campaign contains the *|BRAND:LOGO|* merge tag.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("has_logo_merge_tag")]
    public bool? HasLogoMergeTag { get; set; }

    /// <summary>
    /// A string that uniquely identifies the Automation email.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Determines if the automation email needs its blocks refreshed by opening the web-based campaign editor.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("needs_block_refresh")]
    public bool? NeedsBlockRefresh { get; set; }

    /// <summary>
    /// The position of an Automation email in a workflow.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("position")]
    public int? Position { get; set; }

    /// <summary>
    /// List settings for the campaign.
    /// </summary>
    [JsonPropertyName("recipients")]
    public AutomationWorkflowEmailRecipients? Recipients { get; set; }

    /// <summary>
    /// For sent campaigns, a summary of opens and clicks.
    /// </summary>
    [JsonPropertyName("report_summary")]
    public AutomationWorkflowEmailReportSummary? ReportSummary { get; set; }

    /// <summary>
    /// The date and time a campaign was sent in ISO 8601 format
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("send_time")]
    public DateTime? SendTime { get; set; }

    /// <summary>
    /// Settings for the campaign including the email subject, from name, and from email address.
    /// </summary>
    [JsonPropertyName("settings")]
    public AutomationWorkflowEmailSettings? Settings { get; set; }

    /// <summary>
    /// The preview for the campaign, rendered by social networks like Facebook and Twitter. [Learn more](https://mailchimp.com/help/enable-and-customize-social-cards/).
    /// </summary>
    [JsonPropertyName("social_card")]
    public AutomationWorkflowEmailSocialCard? SocialCard { get; set; }

    /// <summary>
    /// The date and time the campaign was started in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The current status of the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public AutomationWorkflowEmailStatus? Status { get; set; }

    /// <summary>
    /// The tracking options for a campaign.
    /// </summary>
    [JsonPropertyName("tracking")]
    public AutomationWorkflowEmailTracking? Tracking { get; set; }

    /// <summary>
    /// Available triggers for Automation workflows.
    /// </summary>
    [JsonPropertyName("trigger_settings")]
    public AutomationWorkflowEmailTriggerSettings? TriggerSettings { get; set; }

    /// <summary>
    /// The ID used in the Mailchimp web application. View this automation in your Mailchimp account at `https://{dc}.admin.mailchimp.com/campaigns/show/?id={web_id}`.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("web_id")]
    public int? WebId { get; set; }

    /// <summary>
    /// A string that uniquely identifies an Automation workflow.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("workflow_id")]
    public string? WorkflowId { get; set; }

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
