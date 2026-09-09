using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A summary of an individual Automation workflow's settings and content.
/// </summary>
[Serializable]
public record AutomationWorkflow : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<AutomationWorkflowLinksItem>? Links { get; set; }

    /// <summary>
    /// The date and time the Automation was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// The total number of emails sent for the Automation.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// A string that identifies the Automation.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// List settings for the Automation.
    /// </summary>
    [JsonPropertyName("recipients")]
    public AutomationWorkflowRecipients? Recipients { get; set; }

    /// <summary>
    /// A summary of opens and clicks for sent campaigns.
    /// </summary>
    [JsonPropertyName("report_summary")]
    public AutomationWorkflowReportSummary? ReportSummary { get; set; }

    /// <summary>
    /// The settings for the Automation workflow.
    /// </summary>
    [JsonPropertyName("settings")]
    public AutomationWorkflowSettings? Settings { get; set; }

    /// <summary>
    /// The date and time the Automation was started in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The current status of the Automation.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public AutomationWorkflowStatus? Status { get; set; }

    /// <summary>
    /// The tracking options for the Automation.
    /// </summary>
    [JsonPropertyName("tracking")]
    public AutomationWorkflowTracking? Tracking { get; set; }

    /// <summary>
    /// Available triggers for Automation workflows.
    /// </summary>
    [JsonPropertyName("trigger_settings")]
    public AutomationWorkflowTriggerSettings? TriggerSettings { get; set; }

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
