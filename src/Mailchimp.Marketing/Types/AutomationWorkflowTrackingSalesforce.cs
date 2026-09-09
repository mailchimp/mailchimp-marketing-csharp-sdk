using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Deprecated
/// </summary>
[Serializable]
public record AutomationWorkflowTrackingSalesforce : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Create a campaign in a connected Salesforce account.
    /// </summary>
    [JsonPropertyName("campaign")]
    public bool? Campaign { get; set; }

    /// <summary>
    /// Update contact notes for a campaign based on a subscriber's email address.
    /// </summary>
    [JsonPropertyName("notes")]
    public bool? Notes { get; set; }

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
