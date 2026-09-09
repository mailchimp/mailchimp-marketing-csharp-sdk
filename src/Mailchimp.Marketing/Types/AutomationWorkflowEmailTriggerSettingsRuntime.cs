using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A workflow's runtime settings for an Automation.
/// </summary>
[Serializable]
public record AutomationWorkflowEmailTriggerSettingsRuntime : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The days an Automation workflow can send.
    /// </summary>
    [JsonPropertyName("days")]
    public IEnumerable<AutomationWorkflowEmailTriggerSettingsRuntimeDaysItem>? Days { get; set; }

    /// <summary>
    /// The hours an Automation workflow can send.
    /// </summary>
    [JsonPropertyName("hours")]
    public AutomationWorkflowEmailTriggerSettingsRuntimeHours? Hours { get; set; }

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
