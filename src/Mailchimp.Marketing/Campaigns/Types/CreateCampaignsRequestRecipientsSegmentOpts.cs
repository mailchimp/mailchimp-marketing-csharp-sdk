using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An object representing all segmentation options. This object should contain a `saved_segment_id` to use an existing segment, or you can create a new segment by including both `match` and `conditions` options.
/// </summary>
[Serializable]
public record CreateCampaignsRequestRecipientsSegmentOpts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("conditions")]
    public IEnumerable<SegmentTypeItem>? Conditions { get; set; }

    /// <summary>
    /// Segment match type.
    /// </summary>
    [JsonPropertyName("match")]
    public CreateCampaignsRequestRecipientsSegmentOptsMatch? Match { get; set; }

    /// <summary>
    /// The id for an existing saved segment.
    /// </summary>
    [JsonPropertyName("saved_segment_id")]
    public int? SavedSegmentId { get; set; }

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
