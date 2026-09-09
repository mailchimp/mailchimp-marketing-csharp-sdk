using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by average spent total, number of orders, total number of products purchased, or average number of products per order.
/// </summary>
[Serializable]
public record SegmentTypeItemEcommNumber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by average spent total, number of orders, total number of products purchased, or average number of products per order.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemEcommNumberField Field { get; set; }

    /// <summary>
    /// Members who have spent exactly, have not spent exactly, spent more, or spent less than the segment value.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemEcommNumberOp Op { get; set; }

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
