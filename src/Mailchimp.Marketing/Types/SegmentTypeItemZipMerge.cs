using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by an address-type merge field within a given distance.
/// </summary>
[Serializable]
public record SegmentTypeItemZipMerge : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The city or the zip being used to segment against.
    /// </summary>
    [JsonPropertyName("extra")]
    public required string Extra { get; set; }

    /// <summary>
    /// An address or zip-type merge field to segment.
    /// </summary>
    [JsonPropertyName("field")]
    public required string Field { get; set; }

    /// <summary>
    /// Whether the member's address merge field is within a given distance from a city or zip.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemZipMergeOp Op { get; set; }

    /// <summary>
    /// The distance from the city/zip.
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
