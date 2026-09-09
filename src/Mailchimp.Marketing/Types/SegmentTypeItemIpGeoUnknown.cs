using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment members whose location information is unknown.
/// </summary>
[Serializable]
public record SegmentTypeItemIpGeoUnknown : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segmenting subscribers who are within a specific location.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemIpGeoUnknownField Field { get; set; }

    /// <summary>
    /// Segment members for which location information is unknown.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemIpGeoUnknownOp Op { get; set; }

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
