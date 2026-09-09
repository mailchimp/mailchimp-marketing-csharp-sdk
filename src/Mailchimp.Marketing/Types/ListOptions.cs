using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The conditions of the segment. Static segments (tags) and fuzzy segments don't have conditions.
/// </summary>
[Serializable]
public record ListOptions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("conditions")]
    public IEnumerable<SegmentTypeItem>? Conditions { get; set; }

    /// <summary>
    /// Match type.
    /// </summary>
    [JsonPropertyName("match")]
    public ListOptionsMatch? Match { get; set; }

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
