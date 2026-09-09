using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record UpdateEmailAutomationsRequest
{
    /// <summary>
    /// The unique id for the Automation workflow.
    /// </summary>
    [JsonIgnore]
    public required string WorkflowId { get; set; }

    /// <summary>
    /// The unique id for the Automation workflow email.
    /// </summary>
    [JsonIgnore]
    public required string WorkflowEmailId { get; set; }

    /// <summary>
    /// The delay settings for an automation email.
    /// </summary>
    [JsonPropertyName("delay")]
    public UpdateEmailAutomationsRequestDelay? Delay { get; set; }

    /// <summary>
    /// Settings for the campaign including the email subject, from name, and from email address.
    /// </summary>
    [JsonPropertyName("settings")]
    public UpdateEmailAutomationsRequestSettings? Settings { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
