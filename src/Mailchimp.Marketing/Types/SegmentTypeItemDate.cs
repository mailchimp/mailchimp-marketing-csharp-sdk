using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by a specific date field.
/// </summary>
[Serializable]
public record SegmentTypeItemDate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When segmenting on 'date' or 'campaign', the date for the segment formatted as YYYY-MM-DD or the web id for the campaign.
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// The type of date field to segment on: The opt-in time for a signup, the date the subscriber was last updated, or the date of their last ecomm purchase.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemDateField Field { get; set; }

    /// <summary>
    /// When the event took place:  Before, after, is a specific date, is not a specific date, is blank, or is not blank.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemDateOp Op { get; set; }

    /// <summary>
    /// What type of data to segment on: a specific date, a specific campaign, or the last campaign sent.
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
