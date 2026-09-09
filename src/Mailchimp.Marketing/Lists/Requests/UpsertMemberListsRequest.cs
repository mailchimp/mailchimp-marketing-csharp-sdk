using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record UpsertMemberListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// The MD5 hash of the lowercase version of the list member's email address. This endpoint also accepts a list member's email address or contact_id.
    /// </summary>
    [JsonIgnore]
    public required string SubscriberHash { get; set; }

    /// <summary>
    /// If skip_merge_validation is true, member data will be accepted without merge field values, even if the merge field is usually required. This defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? SkipMergeValidation { get; set; }

    /// <summary>
    /// Email address for a subscriber. This value is required only if the email address is not already present on the list.
    /// </summary>
    [JsonPropertyName("email_address")]
    public required string EmailAddress { get; set; }

    /// <summary>
    /// Type of email this member asked to get ('html' or 'text').
    /// </summary>
    [JsonPropertyName("email_type")]
    public string? EmailType { get; set; }

    /// <summary>
    /// The key of this object's properties is the ID of the interest in question.
    /// </summary>
    [JsonPropertyName("interests")]
    public Dictionary<string, bool>? Interests { get; set; }

    /// <summary>
    /// The IP address the subscriber used to confirm their opt-in status.
    /// </summary>
    [JsonPropertyName("ip_opt")]
    public string? IpOpt { get; set; }

    /// <summary>
    /// IP address the subscriber signed up from.
    /// </summary>
    [JsonPropertyName("ip_signup")]
    public string? IpSignup { get; set; }

    /// <summary>
    /// If set/detected, the [subscriber's language](https://mailchimp.com/help/view-and-edit-contact-languages/).
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// Subscriber location information.
    /// </summary>
    [JsonPropertyName("location")]
    public UpsertMemberListsRequestLocation? Location { get; set; }

    /// <summary>
    /// The marketing permissions for the subscriber.
    /// </summary>
    [JsonPropertyName("marketing_permissions")]
    public IEnumerable<UpsertMemberListsRequestMarketingPermissionsItem>? MarketingPermissions { get; set; }

    /// <summary>
    /// A dictionary of merge fields where the keys are the merge tags. See the [Merge Fields documentation](https://mailchimp.com/developer/marketing/docs/merge-fields/#structure) for more about the structure.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public Dictionary<
        string,
        OneOf<UpsertMemberListsRequestMergeFieldsValueAddr1, string, double>
    >? MergeFields { get; set; }

    /// <summary>
    /// Subscriber's current status.
    /// </summary>
    [JsonPropertyName("status")]
    public UpsertMemberListsRequestStatus? Status { get; set; }

    /// <summary>
    /// Subscriber's status. This value is required only if the email address is not already present on the list.
    /// </summary>
    [JsonPropertyName("status_if_new")]
    public UpsertMemberListsRequestStatusIfNew? StatusIfNew { get; set; }

    /// <summary>
    /// The tags that are associated with a member.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

    [JsonPropertyName("timestamp_opt")]
    public OneOf<string, UpsertMemberListsRequestTimestampOptOne>? TimestampOpt { get; set; }

    [JsonPropertyName("timestamp_signup")]
    public OneOf<string, UpsertMemberListsRequestTimestampSignupOne>? TimestampSignup { get; set; }

    /// <summary>
    /// [VIP status](https://mailchimp.com/help/designate-and-send-to-vip-contacts/) for subscriber.
    /// </summary>
    [JsonPropertyName("vip")]
    public bool? Vip { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
