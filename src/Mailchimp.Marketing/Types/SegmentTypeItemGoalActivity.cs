using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by Goal activity.
/// </summary>
[Serializable]
public record SegmentTypeItemGoalActivity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by Goal activity.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemGoalActivityField Field { get; set; }

    /// <summary>
    /// Whether the website URL is/not exactly, contains/doesn't contain, starts with/ends with a string.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemGoalActivityOp Op { get; set; }

    /// <summary>
    /// The URL to check Goal activity against.
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
