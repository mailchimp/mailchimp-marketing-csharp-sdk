using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// A list of a member's opens activity in a specific campaign.
/// </summary>
[Serializable]
public record OpenActivity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<OpenActivityLinksItem>? Links { get; set; }

    /// <summary>
    /// The unique id for the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// The status of the member, namely if they are subscribed, unsubscribed, deleted, non-subscribed, transactional, pending, or need reconfirmation.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("contact_status")]
    public string? ContactStatus { get; set; }

    /// <summary>
    /// Email address for a subscriber.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The MD5 hash of the lowercase version of the list member's email address.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("email_id")]
    public string? EmailId { get; set; }

    /// <summary>
    /// The unique id for the list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// The status of the list used, namely if it's deleted or disabled.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_is_active")]
    public bool? ListIsActive { get; set; }

    /// <summary>
    /// A dictionary of merge fields where the keys are the merge tags. See the [Merge Fields documentation](https://mailchimp.com/developer/marketing/docs/merge-fields/#structure) for more about the structure.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public Dictionary<
        string,
        OneOf<OpenActivityMergeFieldsValueAddr1, string, double>
    >? MergeFields { get; set; }

    /// <summary>
    /// An array of timestamps for each time a list member opened the campaign. If a list member opens an email multiple times, this will return a separate timestamp for each open event.
    /// </summary>
    [JsonPropertyName("opens")]
    public IEnumerable<OpenActivityOpensItem>? Opens { get; set; }

    /// <summary>
    /// The total number of times the this campaign was opened by the list member.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("opens_count")]
    public int? OpensCount { get; set; }

    /// <summary>
    /// The total number of times the this campaign was opened by the list member excluding opens from email clients that use proxies .
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("proxy_excluded_opens_count")]
    public int? ProxyExcludedOpensCount { get; set; }

    /// <summary>
    /// [VIP status](https://mailchimp.com/help/designate-and-send-to-vip-contacts/) for subscriber.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("vip")]
    public bool? Vip { get; set; }

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
