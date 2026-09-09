using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by age ranges in Social Profiles data.
/// </summary>
[Serializable]
public record SegmentTypeItemSocialAge : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by age ranges in Social Profiles data.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemSocialAgeField Field { get; set; }

    /// <summary>
    /// Members who are/not the exact criteria listed.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemSocialAgeOp Op { get; set; }

    /// <summary>
    /// The age range to segment.
    /// </summary>
    [JsonPropertyName("value")]
    public required SegmentTypeItemSocialAgeValue Value { get; set; }

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
