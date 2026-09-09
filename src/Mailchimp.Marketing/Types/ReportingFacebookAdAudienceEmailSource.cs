using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ReportingFacebookAdAudienceEmailSource : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Is the source reference a segment
    /// </summary>
    [JsonPropertyName("is_segment")]
    public bool? IsSegment { get; set; }

    /// <summary>
    /// Associated list name to the source
    /// </summary>
    [JsonPropertyName("list_name")]
    public string? ListName { get; set; }

    /// <summary>
    /// Email source name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Segment type if this source is tied to a segment
    /// </summary>
    [JsonPropertyName("segment_type")]
    public string? SegmentType { get; set; }

    /// <summary>
    /// Type of the email source
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

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
