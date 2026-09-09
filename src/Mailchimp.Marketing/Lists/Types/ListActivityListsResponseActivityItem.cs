using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// One day's worth of list activity. Doesn't include Automation activity.
/// </summary>
[Serializable]
public record ListActivityListsResponseActivityItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListActivityListsResponseActivityItemLinksItem>? Links { get; set; }

    /// <summary>
    /// The date for the activity summary.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// The total number of emails sent on the date for the activity summary.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// The number of hard bounces.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("hard_bounce")]
    public int? HardBounce { get; set; }

    /// <summary>
    /// The number of subscribers who may have been added outside of the [double opt-in process](https://mailchimp.com/help/about-double-opt-in/), such as imports or API activity.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("other_adds")]
    public int? OtherAdds { get; set; }

    /// <summary>
    /// The number of subscribers who may have been removed outside of unsubscribing or reporting an email as spam (for example, deleted subscribers).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("other_removes")]
    public int? OtherRemoves { get; set; }

    /// <summary>
    /// The number of clicks.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("recipient_clicks")]
    public int? RecipientClicks { get; set; }

    /// <summary>
    /// The number of soft bounces
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("soft_bounce")]
    public int? SoftBounce { get; set; }

    /// <summary>
    /// The number of subscribes.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subs")]
    public int? Subs { get; set; }

    /// <summary>
    /// The number of unique opens.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_opens")]
    public int? UniqueOpens { get; set; }

    /// <summary>
    /// The number of unsubscribes.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unsubs")]
    public int? Unsubs { get; set; }

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
