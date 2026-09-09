using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by most recent interaction with a website.
/// </summary>
[Serializable]
public record SegmentTypeItemGoalTimestamp : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by most recent interaction with a website.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemGoalTimestampField Field { get; set; }

    /// <summary>
    /// Whether the website activity happened after, before, or at a given timestamp.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemGoalTimestampOp Op { get; set; }

    /// <summary>
    /// The date to check Goal activity against.
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
