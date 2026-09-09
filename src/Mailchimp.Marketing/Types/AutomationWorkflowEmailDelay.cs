using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The delay settings for an Automation email.
/// </summary>
[Serializable]
public record AutomationWorkflowEmailDelay : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The action that triggers the delay of an Automation email.
    /// </summary>
    [JsonPropertyName("action")]
    public AutomationWorkflowEmailDelayAction? Action { get; set; }

    /// <summary>
    /// The user-friendly description of the action that triggers an Automation email.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("action_description")]
    public string? ActionDescription { get; set; }

    /// <summary>
    /// The delay amount for an Automation email.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// Whether the delay settings describe before or after the delay action of an Automation email.
    /// </summary>
    [JsonPropertyName("direction")]
    public AutomationWorkflowEmailDelayDirection? Direction { get; set; }

    /// <summary>
    /// The user-friendly description of the delay and trigger action settings for an Automation email.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("full_description")]
    public string? FullDescription { get; set; }

    /// <summary>
    /// The type of delay for an Automation email.
    /// </summary>
    [JsonPropertyName("type")]
    public AutomationWorkflowEmailDelayType? Type { get; set; }

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
