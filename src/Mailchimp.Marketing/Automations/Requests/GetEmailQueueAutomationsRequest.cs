using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record GetEmailQueueAutomationsRequest
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
    /// The MD5 hash of the lowercase version of the list member's email address.
    /// </summary>
    [JsonIgnore]
    public required string SubscriberHash { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
