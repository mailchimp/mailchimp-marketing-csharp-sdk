using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by purchases from a specific store.
/// </summary>
[Serializable]
public record SegmentTypeItemEcommStore : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by purchases from a specific store.
    /// </summary>
    [JsonPropertyName("field")]
    public SegmentTypeItemEcommStoreField? Field { get; set; }

    /// <summary>
    /// Members who have or have not purchased from a specific store.
    /// </summary>
    [JsonPropertyName("op")]
    public SegmentTypeItemEcommStoreOp? Op { get; set; }

    /// <summary>
    /// The store id to segment against.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

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
