using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by VIP status.
/// </summary>
[Serializable]
public record SegmentTypeItemVip : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by VIP status.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemVipField Field { get; set; }

    /// <summary>
    /// Whether the member is or is not marked as VIP.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemVipOp Op { get; set; }

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
