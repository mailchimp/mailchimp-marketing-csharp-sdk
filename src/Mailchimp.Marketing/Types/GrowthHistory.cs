using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A summary of a specific list's growth activity for a specific month and year.
/// </summary>
[Serializable]
public record GrowthHistory : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<GrowthHistoryLinksItem>? Links { get; set; }

    /// <summary>
    /// Newly cleaned (hard-bounced) members on the list for a specific month.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("cleaned")]
    public int? Cleaned { get; set; }

    /// <summary>
    /// Newly deleted members on the list for a specific month.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("deleted")]
    public int? Deleted { get; set; }

    /// <summary>
    /// (deprecated)
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("existing")]
    public int? Existing { get; set; }

    /// <summary>
    /// (deprecated)
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("imports")]
    public int? Imports { get; set; }

    /// <summary>
    /// The list id for the growth activity report.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// The month that the growth history is describing.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("month")]
    public string? Month { get; set; }

    /// <summary>
    /// (deprecated)
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("optins")]
    public int? Optins { get; set; }

    /// <summary>
    /// Pending members on the list for a specific month.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("pending")]
    public int? Pending { get; set; }

    /// <summary>
    /// Newly reconfirmed members on the list for a specific month.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("reconfirm")]
    public int? Reconfirm { get; set; }

    /// <summary>
    /// Total subscribed members on the list at the end of the month.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subscribed")]
    public int? Subscribed { get; set; }

    /// <summary>
    /// Subscribers that have been sent transactional emails via Mandrill.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("transactional")]
    public int? Transactional { get; set; }

    /// <summary>
    /// Newly unsubscribed members on the list for a specific month.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unsubscribed")]
    public int? Unsubscribed { get; set; }

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
