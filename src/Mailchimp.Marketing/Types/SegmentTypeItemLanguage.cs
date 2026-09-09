using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by language.
/// </summary>
[Serializable]
public record SegmentTypeItemLanguage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segmenting based off of a subscriber's language.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemLanguageField Field { get; set; }

    /// <summary>
    /// Whether the member's language is or is not set to a specific language.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemLanguageOp Op { get; set; }

    /// <summary>
    /// A two-letter language identifier.
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
