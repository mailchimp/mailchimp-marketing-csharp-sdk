using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by a specific US ZIP code.
/// </summary>
[Serializable]
public record SegmentTypeItemIpGeoZip : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segmenting subscribers who are within a specific location.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemIpGeoZipField Field { get; set; }

    /// <summary>
    /// Segment members who are/are not within a specific US zip code.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemIpGeoZipOp Op { get; set; }

    /// <summary>
    /// The 5-digit zip code.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }

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
