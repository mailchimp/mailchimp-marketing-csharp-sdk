using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Stats for the list. Many of these are cached for at least five minutes.
/// </summary>
[Serializable]
public record SubscriberListStats : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The average number of subscriptions per month for the list (not returned if we haven't calculated it yet).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("avg_sub_rate")]
    public double? AvgSubRate { get; set; }

    /// <summary>
    /// The average number of unsubscriptions per month for the list (not returned if we haven't calculated it yet).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("avg_unsub_rate")]
    public double? AvgUnsubRate { get; set; }

    /// <summary>
    /// The number of campaigns in any status that use this list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("campaign_count")]
    public int? CampaignCount { get; set; }

    /// <summary>
    /// The date and time the last campaign was sent to this list in ISO 8601 format. This is updated when a campaign is sent to 10 or more recipients.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("campaign_last_sent")]
    public DateTime? CampaignLastSent { get; set; }

    /// <summary>
    /// The number of members cleaned from the list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("cleaned_count")]
    public int? CleanedCount { get; set; }

    /// <summary>
    /// The number of members cleaned from the list since the last campaign was sent.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("cleaned_count_since_send")]
    public int? CleanedCountSinceSend { get; set; }

    /// <summary>
    /// The average click rate (a percentage represented as a number between 0 and 100) per campaign for the list (not returned if we haven't calculated it yet).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    /// <summary>
    /// The date and time of the last time someone subscribed to this list in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_sub_date")]
    public DateTime? LastSubDate { get; set; }

    /// <summary>
    /// The date and time of the last time someone unsubscribed from this list in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_unsub_date")]
    public DateTime? LastUnsubDate { get; set; }

    /// <summary>
    /// The number of active members in the list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("member_count")]
    public int? MemberCount { get; set; }

    /// <summary>
    /// The number of active members in the list since the last campaign was sent.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("member_count_since_send")]
    public int? MemberCountSinceSend { get; set; }

    /// <summary>
    /// The number of merge fields ([audience field](https://mailchimp.com/help/getting-started-with-merge-tags/)) for this list (doesn't include EMAIL).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("merge_field_count")]
    public int? MergeFieldCount { get; set; }

    /// <summary>
    /// The average open rate (a percentage represented as a number between 0 and 100) per campaign for the list (not returned if we haven't calculated it yet).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("open_rate")]
    public double? OpenRate { get; set; }

    /// <summary>
    /// The target number of subscriptions per month for the list to keep it growing (not returned if we haven't calculated it yet).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("target_sub_rate")]
    public double? TargetSubRate { get; set; }

    /// <summary>
    /// An approximate count of subscribed, unsubscribed, and transactional contacts in the list. Does not include cleaned, archived, pending, or contacts that need to be reconfirmed. Requires the (deprecated) include_total_contacts query parameter to be included; for a complete audience contact count, use the /audiences endpoint instead.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_contacts")]
    public int? TotalContacts { get; set; }

    /// <summary>
    /// The number of members who have unsubscribed from the list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unsubscribe_count")]
    public int? UnsubscribeCount { get; set; }

    /// <summary>
    /// The number of members who have unsubscribed since the last campaign was sent.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unsubscribe_count_since_send")]
    public int? UnsubscribeCountSinceSend { get; set; }

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
