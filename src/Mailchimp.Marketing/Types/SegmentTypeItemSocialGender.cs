using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by listed gender in Social Profiles data.
/// </summary>
[Serializable]
public record SegmentTypeItemSocialGender : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by listed gender in Social Profiles data.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemSocialGenderField Field { get; set; }

    /// <summary>
    /// Members who are/not the exact criteria listed.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemSocialGenderOp Op { get; set; }

    /// <summary>
    /// The Social Profiles gender to segment.
    /// </summary>
    [JsonPropertyName("value")]
    public required SegmentTypeItemSocialGenderValue Value { get; set; }

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
