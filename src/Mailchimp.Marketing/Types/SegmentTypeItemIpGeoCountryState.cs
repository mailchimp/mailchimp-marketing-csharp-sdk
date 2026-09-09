using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by a specific country or US state.
/// </summary>
[Serializable]
public record SegmentTypeItemIpGeoCountryState : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segmenting subscribers who are within a specific location.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemIpGeoCountryStateField Field { get; set; }

    /// <summary>
    /// Segment members who are within a specific country or US state.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemIpGeoCountryStateOp Op { get; set; }

    /// <summary>
    /// The two-letter country code or US state abbreviation.
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
