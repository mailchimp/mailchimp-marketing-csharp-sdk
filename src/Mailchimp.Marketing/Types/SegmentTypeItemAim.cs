using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by interaction with a specific campaign.
/// </summary>
[Serializable]
public record SegmentTypeItemAim : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by interaction with a specific campaign.
    /// </summary>
    [JsonPropertyName("field")]
    public SegmentTypeItemAimField? Field { get; set; }

    /// <summary>
    /// The status of the member with regard to their campaign interaction. One of the following: opened, clicked, was sent, didn't open, didn't click, or was not sent.
    /// </summary>
    [JsonPropertyName("op")]
    public SegmentTypeItemAimOp? Op { get; set; }

    /// <summary>
    /// Either the web id value for a specific campaign or 'any' to account for subscribers who have/have not interacted with any campaigns.
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
