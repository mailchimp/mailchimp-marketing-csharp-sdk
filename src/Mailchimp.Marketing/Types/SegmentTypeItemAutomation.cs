using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by interaction with an Automation workflow.
/// </summary>
[Serializable]
public record SegmentTypeItemAutomation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by interaction with an Automation workflow.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemAutomationField Field { get; set; }

    /// <summary>
    /// The status of the member with regard to the automation workflow. One of the following: has started the workflow, has completed the workflow, has not started the workflow, or has not completed the workflow.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemAutomationOp Op { get; set; }

    /// <summary>
    /// The web id for the automation workflow to segment against.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
