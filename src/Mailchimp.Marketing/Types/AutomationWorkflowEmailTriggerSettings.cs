using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Available triggers for Automation workflows.
/// </summary>
[Serializable]
public record AutomationWorkflowEmailTriggerSettings : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A workflow's runtime settings for an Automation.
    /// </summary>
    [JsonPropertyName("runtime")]
    public AutomationWorkflowEmailTriggerSettingsRuntime? Runtime { get; set; }

    /// <summary>
    /// The number of emails in the Automation workflow.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("workflow_emails_count")]
    public int? WorkflowEmailsCount { get; set; }

    /// <summary>
    /// The title of the workflow type.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("workflow_title")]
    public string? WorkflowTitle { get; set; }

    /// <summary>
    /// The type of Automation workflow.
    /// </summary>
    [JsonPropertyName("workflow_type")]
    public required AutomationWorkflowEmailTriggerSettingsWorkflowType WorkflowType { get; set; }

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
