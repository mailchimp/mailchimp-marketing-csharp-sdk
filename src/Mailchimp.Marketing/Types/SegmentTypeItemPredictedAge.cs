using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by predicted age.
/// </summary>
[Serializable]
public record SegmentTypeItemPredictedAge : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by predicted age.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemPredictedAgeField Field { get; set; }

    /// <summary>
    /// Members who are/not the exact criteria listed.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemPredictedAgeOp Op { get; set; }

    /// <summary>
    /// The predicted age to segment.
    /// </summary>
    [JsonPropertyName("value")]
    public required SegmentTypeItemPredictedAgeValue Value { get; set; }

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
