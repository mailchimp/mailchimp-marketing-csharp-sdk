using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListCampaignsRequest
{
    /// <summary>
    /// A comma-separated list of fields to return. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Fields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// A comma-separated list of fields to exclude. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ExcludeFields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// The number of records to return. Default value is 10. Maximum value is 1000
    /// </summary>
    [JsonIgnore]
    public int? Count { get; set; }

    /// <summary>
    /// Used for [pagination](https://mailchimp.com/developer/marketing/docs/methods-parameters/#pagination), this is the number of records from a collection to skip. Default value is 0.
    /// </summary>
    [JsonIgnore]
    public int? Offset { get; set; }

    /// <summary>
    /// The campaign type.
    /// </summary>
    [JsonIgnore]
    public ListCampaignsRequestType? Type { get; set; }

    /// <summary>
    /// The status of the campaign.
    /// </summary>
    [JsonIgnore]
    public ListCampaignsRequestStatus? Status { get; set; }

    /// <summary>
    /// Restrict the response to campaigns sent before the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? BeforeSendTime { get; set; }

    /// <summary>
    /// Restrict the response to campaigns sent after the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? SinceSendTime { get; set; }

    /// <summary>
    /// Restrict the response to campaigns created before the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? BeforeCreateTime { get; set; }

    /// <summary>
    /// Restrict the response to campaigns created after the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? SinceCreateTime { get; set; }

    /// <summary>
    /// The unique id for the list.
    /// </summary>
    [JsonIgnore]
    public string? ListId { get; set; }

    /// <summary>
    /// The unique folder id.
    /// </summary>
    [JsonIgnore]
    public string? FolderId { get; set; }

    /// <summary>
    /// Retrieve campaigns sent to a particular list member. Member ID is The MD5 hash of the lowercase version of the list member’s email address.
    /// </summary>
    [JsonIgnore]
    public string? MemberId { get; set; }

    /// <summary>
    /// Returns files sorted by the specified field.
    /// </summary>
    [JsonIgnore]
    public ListCampaignsRequestSortField? SortField { get; set; }

    /// <summary>
    /// Determines the order direction for sorted results.
    /// </summary>
    [JsonIgnore]
    public ListCampaignsRequestSortDir? SortDir { get; set; }

    /// <summary>
    /// Return the `resend_shortcut_eligibility` field in the response, which tells you if the campaign is eligible for the various Campaign Resend Shortcuts offered.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeResendShortcutEligibility { get; set; }

    /// <summary>
    /// Return the `resend_shortcut_usage` field in the response.  This includes information about campaigns related by a shortcut.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeResendShortcutUsage { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
