using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateAutomationsRequest
{
    /// <summary>
    /// List settings for the Automation.
    /// </summary>
    [JsonPropertyName("recipients")]
    public required CreateAutomationsRequestRecipients Recipients { get; set; }

    /// <summary>
    /// The settings for the Automation workflow.
    /// </summary>
    [JsonPropertyName("settings")]
    public CreateAutomationsRequestSettings? Settings { get; set; }

    /// <summary>
    /// Trigger settings for the Automation.
    /// </summary>
    [JsonPropertyName("trigger_settings")]
    public required CreateAutomationsRequestTriggerSettings TriggerSettings { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
