using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A single SMS campaign.
/// </summary>
[Serializable]
public record SmsCampaign : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A string that uniquely identifies this campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The ID used in the Mailchimp web application.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("web_id")]
    public string? WebId { get; set; }

    /// <summary>
    /// The name of the campaign.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The current status of the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The channel for this campaign (sms or whatsapp).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// The numeric ID of the list associated with this campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public int? ListId { get; set; }

    /// <summary>
    /// The number of recipients for this campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("recipient_count")]
    public int? RecipientCount { get; set; }

    /// <summary>
    /// The date and time the campaign was created.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// The date and time the campaign is scheduled to send.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("send_time")]
    public DateTime? SendTime { get; set; }

    /// <summary>
    /// The date and time the campaign was last updated.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The date and time the campaign will stop sending in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("expire_time")]
    public DateTime? ExpireTime { get; set; }

    /// <summary>
    /// Whether the campaign is configured to send immediately.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("is_send_now")]
    public bool? IsSendNow { get; set; }

    /// <summary>
    /// The ID of the folder this campaign is in.
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string? FolderId { get; set; }

    /// <summary>
    /// The segment IDs used to target recipients for this campaign.
    /// </summary>
    [JsonPropertyName("segments")]
    public IEnumerable<int>? Segments { get; set; }

    /// <summary>
    /// The segment IDs excluded from receiving this campaign.
    /// </summary>
    [JsonPropertyName("excluded_segments")]
    public IEnumerable<int>? ExcludedSegments { get; set; }

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<SmsCampaignLinksItem>? Links { get; set; }

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
