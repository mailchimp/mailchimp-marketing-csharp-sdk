using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by when people subscribed.
/// </summary>
[Serializable]
public record SegmentTypeItemNewSubscribers : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by when people subscribed.
    /// </summary>
    [JsonPropertyName("field")]
    public SegmentTypeItemNewSubscribersField? Field { get; set; }

    /// <summary>
    /// Whe the event took place, namely within a time frame.
    /// </summary>
    [JsonPropertyName("op")]
    public SegmentTypeItemNewSubscribersOp? Op { get; set; }

    /// <summary>
    /// What type of data to segment on: a specific date, a specific campaign, or the last campaign sent.
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
