using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Individuals who are currently or have been previously subscribed to this list, including members who have bounced or unsubscribed.
/// </summary>
[Serializable]
public record ListMembers : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListMembersLinksItem>? Links { get; set; }

    /// <summary>
    /// Indicates whether a contact consents to 1:1 messaging.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("consents_to_one_to_one_messaging")]
    public bool? ConsentsToOneToOneMessaging { get; set; }

    /// <summary>
    /// As Mailchimp evolves beyond email, you may eventually have contacts without email addresses. While the `id` is the MD5 hash of their email address, this `contact_id` is agnostic of contact’s inclusion of an email address.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("contact_id")]
    public string? ContactId { get; set; }

    /// <summary>
    /// Email address for a subscriber.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The list member's email client.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("email_client")]
    public string? EmailClient { get; set; }

    /// <summary>
    /// Type of email this member asked to get ('html' or 'text').
    /// </summary>
    [JsonPropertyName("email_type")]
    public object? EmailType { get; set; }

    /// <summary>
    /// The MD5 hash of the lowercase version of the list member's email address.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The key of this object's properties is the ID of the interest in question.
    /// </summary>
    [JsonPropertyName("interests")]
    public Dictionary<string, bool>? Interests { get; set; }

    /// <summary>
    /// The IP address the subscriber used to confirm their opt-in status.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("ip_opt")]
    public string? IpOpt { get; set; }

    /// <summary>
    /// IP address the subscriber signed up from.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("ip_signup")]
    public string? IpSignup { get; set; }

    /// <summary>
    /// If set/detected, the [subscriber's language](https://mailchimp.com/help/view-and-edit-contact-languages/).
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// The date and time the member's info was last changed in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_changed")]
    public DateTime? LastChanged { get; set; }

    /// <summary>
    /// The most recent Note added about this member.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_note")]
    public ListMembersLastNote? LastNote { get; set; }

    /// <summary>
    /// The list id.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// Subscriber location information.
    /// </summary>
    [JsonPropertyName("location")]
    public ListMembersLocation? Location { get; set; }

    /// <summary>
    /// The marketing permissions for the subscriber.
    /// </summary>
    [JsonPropertyName("marketing_permissions")]
    public IEnumerable<ListMembersMarketingPermissionsItem>? MarketingPermissions { get; set; }

    /// <summary>
    /// Star rating for this member, between 1 and 5.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("member_rating")]
    public int? MemberRating { get; set; }

    /// <summary>
    /// A dictionary of merge fields where the keys are the merge tags. See the [Merge Fields documentation](https://mailchimp.com/developer/marketing/docs/merge-fields/#structure) for more about the structure.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public Dictionary<
        string,
        OneOf<ListMembersMergeFieldsValueAddr1, string, double>
    >? MergeFields { get; set; }

    /// <summary>
    /// A US phone number for SMS contact.
    /// </summary>
    [JsonPropertyName("sms_phone_number")]
    public string? SmsPhoneNumber { get; set; }

    /// <summary>
    /// The datetime when the SMS subscription was last updated
    /// </summary>
    [JsonPropertyName("sms_subscription_last_updated")]
    public string? SmsSubscriptionLastUpdated { get; set; }

    /// <summary>
    /// The status of an SMS subscription.
    /// </summary>
    [JsonPropertyName("sms_subscription_status")]
    public ListMembersSmsSubscriptionStatus? SmsSubscriptionStatus { get; set; }

    /// <summary>
    /// The source from which the subscriber was added to this list.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// Open and click rates for this subscriber.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("stats")]
    public ListMembersStats? Stats { get; set; }

    /// <summary>
    /// Subscriber's current status.
    /// </summary>
    [JsonPropertyName("status")]
    public ListMembersStatus? Status { get; set; }

    /// <summary>
    /// Returns up to 50 tags applied to this member. To retrieve all tags see [Member Tags](https://mailchimp.com/developer/marketing/api/list-member-tags/).
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<ListMembersTagsItem>? Tags { get; set; }

    /// <summary>
    /// The number of tags applied to this member.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("tags_count")]
    public int? TagsCount { get; set; }

    /// <summary>
    /// The date and time the subscriber confirmed their opt-in status in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("timestamp_opt")]
    public DateTime? TimestampOpt { get; set; }

    /// <summary>
    /// The date and time the subscriber signed up for the list in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("timestamp_signup")]
    public DateTime? TimestampSignup { get; set; }

    /// <summary>
    /// An identifier for the address across all of Mailchimp.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_email_id")]
    public string? UniqueEmailId { get; set; }

    /// <summary>
    /// A subscriber's reason for unsubscribing.
    /// </summary>
    [JsonPropertyName("unsubscribe_reason")]
    public string? UnsubscribeReason { get; set; }

    /// <summary>
    /// [VIP status](https://mailchimp.com/help/designate-and-send-to-vip-contacts/) for subscriber.
    /// </summary>
    [JsonPropertyName("vip")]
    public bool? Vip { get; set; }

    /// <summary>
    /// The ID used in the Mailchimp web application. View this member in your Mailchimp account at `https://{dc}.admin.mailchimp.com/lists/members/view?id={web_id}`.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("web_id")]
    public int? WebId { get; set; }

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
