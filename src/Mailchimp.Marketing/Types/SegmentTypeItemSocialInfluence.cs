using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by influence rating in Social Profiles data.
/// </summary>
[Serializable]
public record SegmentTypeItemSocialInfluence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by influence rating in Social Profiles data.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemSocialInfluenceField Field { get; set; }

    /// <summary>
    /// Members who have a rating that is/not or greater/less than the rating provided.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemSocialInfluenceOp Op { get; set; }

    /// <summary>
    /// The Social Profiles influence rating to segment.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

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
