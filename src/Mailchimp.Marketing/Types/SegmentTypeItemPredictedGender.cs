using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by predicted gender.
/// </summary>
[Serializable]
public record SegmentTypeItemPredictedGender : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by predicted gender.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemPredictedGenderField Field { get; set; }

    /// <summary>
    /// Members who are/not the exact criteria listed.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemPredictedGenderOp Op { get; set; }

    /// <summary>
    /// The predicted gender to segment.
    /// </summary>
    [JsonPropertyName("value")]
    public required SegmentTypeItemPredictedGenderValue Value { get; set; }

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
