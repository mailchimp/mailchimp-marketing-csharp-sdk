using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// A subscriber's status for a specific campaign.
/// </summary>
[Serializable]
public record SentTo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<SentToLinksItem>? Links { get; set; }

    /// <summary>
    /// For A/B Split Campaigns, the group the member was apart of.
    /// </summary>
    [JsonPropertyName("absplit_group")]
    public SentToAbsplitGroup? AbsplitGroup { get; set; }

    /// <summary>
    /// The campaign id.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }

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
    /// For campaigns sent with timewarp, the time zone group the member is apart of.
    /// </summary>
    [JsonPropertyName("gmt_offset")]
    public int? GmtOffset { get; set; }

    /// <summary>
    /// The date and time of the last open for this member in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_open")]
    public DateTime? LastOpen { get; set; }

    /// <summary>
    /// The unique list id.
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
        OneOf<SentToMergeFieldsValueAddr1, string, double>
    >? MergeFields { get; set; }

    /// <summary>
    /// The number of times a campaign was opened by this member.
    /// </summary>
    [JsonPropertyName("open_count")]
    public int? OpenCount { get; set; }

    /// <summary>
    /// The status of the email delivered to this subscriber. `hard` and `soft` refer to different [bounce types](https://mailchimp.com/help/soft-vs-hard-bounces/).
    /// </summary>
    [JsonPropertyName("status")]
    public SentToStatus? Status { get; set; }

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
