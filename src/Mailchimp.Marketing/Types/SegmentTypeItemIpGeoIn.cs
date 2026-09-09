using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by a specific geographic region.
/// </summary>
[Serializable]
public record SegmentTypeItemIpGeoIn : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The address of the target location.
    /// </summary>
    [JsonPropertyName("addr")]
    public required string Addr { get; set; }

    /// <summary>
    /// Segmenting subscribers who are within a specific location.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemIpGeoInField Field { get; set; }

    /// <summary>
    /// The latitude of the target location.
    /// </summary>
    [JsonPropertyName("lat")]
    public required string Lat { get; set; }

    /// <summary>
    /// The longitude of the target location.
    /// </summary>
    [JsonPropertyName("lng")]
    public required string Lng { get; set; }

    /// <summary>
    /// Segment members who are within a specific geographic region.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemIpGeoInOp Op { get; set; }

    /// <summary>
    /// The radius of the target location.
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
