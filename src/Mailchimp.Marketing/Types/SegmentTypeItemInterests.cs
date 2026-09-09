using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by an interest group merge field.
/// </summary>
[Serializable]
public record SegmentTypeItemInterests : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segmenting based on interest group information. This should start with 'interests-' followed by the grouping id. Ex. 'interests-123'.
    /// </summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>
    /// Whether the member is a part of one, all, or none of the groups.
    /// </summary>
    [JsonPropertyName("op")]
    public SegmentTypeItemInterestsOp? Op { get; set; }

    /// <summary>
    /// An array containing strings, each representing a group id.
    /// </summary>
    [JsonPropertyName("value")]
    public IEnumerable<string>? Value { get; set; }

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
