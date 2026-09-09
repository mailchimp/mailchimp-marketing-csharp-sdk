using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The content of an SMS campaign.
/// </summary>
[Serializable]
public record SmsCampaignContent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The SMS message body.
    /// </summary>
    [JsonPropertyName("message_body")]
    public string? MessageBody { get; set; }

    /// <summary>
    /// The estimated number of message segments this content will use.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("estimated_segments")]
    public int? EstimatedSegments { get; set; }

    /// <summary>
    /// The merge fields used in the message body.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("merge_fields")]
    public IEnumerable<string>? MergeFields { get; set; }

    /// <summary>
    /// Attached images or files.
    /// </summary>
    [JsonPropertyName("media")]
    public IEnumerable<SmsCampaignContentMediaItem>? Media { get; set; }

    /// <summary>
    /// The source that created or imported this content.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("source")]
    public SmsCampaignContentSource? Source { get; set; }

    /// <summary>
    /// Additional content properties.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("properties")]
    public SmsCampaignContentProperties? Properties { get; set; }

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<SmsCampaignContentLinksItem>? Links { get; set; }

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
