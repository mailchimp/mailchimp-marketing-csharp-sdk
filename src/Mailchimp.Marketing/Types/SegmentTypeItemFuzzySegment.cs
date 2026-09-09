using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by similar subscribers.
/// </summary>
[Serializable]
public record SegmentTypeItemFuzzySegment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by similar subscribers.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemFuzzySegmentField Field { get; set; }

    /// <summary>
    /// Members who are/are not apart of a 'similar subscribers' segment.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemFuzzySegmentOp Op { get; set; }

    [JsonPropertyName("value")]
    public required OneOf<double, string> Value { get; set; }

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
