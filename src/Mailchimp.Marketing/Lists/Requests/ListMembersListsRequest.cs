using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListMembersListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

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
    /// The email type.
    /// </summary>
    [JsonIgnore]
    public string? EmailType { get; set; }

    /// <summary>
    /// The subscriber's status.
    /// </summary>
    [JsonIgnore]
    public ListMembersListsRequestStatus? Status { get; set; }

    /// <summary>
    /// Restrict results to subscribers who opted-in after the set timeframe. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? SinceTimestampOpt { get; set; }

    /// <summary>
    /// Restrict results to subscribers who opted-in before the set timeframe. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? BeforeTimestampOpt { get; set; }

    /// <summary>
    /// Restrict results to subscribers whose information changed after the set timeframe. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? SinceLastChanged { get; set; }

    /// <summary>
    /// Restrict results to subscribers whose information changed before the set timeframe. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? BeforeLastChanged { get; set; }

    /// <summary>
    /// A unique identifier for the email address across all Mailchimp lists.
    /// </summary>
    [JsonIgnore]
    public string? UniqueEmailId { get; set; }

    /// <summary>
    /// A filter to return only the list's VIP members. Passing `true` will restrict results to VIP list members, passing `false` will return all list members.
    /// </summary>
    [JsonIgnore]
    public bool? VipOnly { get; set; }

    /// <summary>
    /// The unique id for the interest category.
    /// </summary>
    [JsonIgnore]
    public string? InterestCategoryId { get; set; }

    /// <summary>
    /// Used to filter list members by interests. Must be accompanied by interest_category_id and interest_match. The value must be a comma separated list of interest ids present for any supplied interest categories.
    /// </summary>
    [JsonIgnore]
    public string? InterestIds { get; set; }

    /// <summary>
    /// Used to filter list members by interests. Must be accompanied by interest_category_id and interest_ids. "any" will match a member with any of the interest supplied, "all" will only match members with every interest supplied, and "none" will match members without any of the interest supplied.
    /// </summary>
    [JsonIgnore]
    public ListMembersListsRequestInterestMatch? InterestMatch { get; set; }

    /// <summary>
    /// Returns files sorted by the specified field.
    /// </summary>
    [JsonIgnore]
    public ListMembersListsRequestSortField? SortField { get; set; }

    /// <summary>
    /// Determines the order direction for sorted results.
    /// </summary>
    [JsonIgnore]
    public ListMembersListsRequestSortDir? SortDir { get; set; }

    /// <summary>
    /// Filter subscribers by those subscribed/unsubscribed/pending/cleaned since last email campaign send. Member status is required to use this filter.
    /// </summary>
    [JsonIgnore]
    public bool? SinceLastCampaign { get; set; }

    /// <summary>
    /// Filter subscribers by those unsubscribed since a specific date. Using any status other than unsubscribed with this filter will result in an error.
    /// </summary>
    [JsonIgnore]
    public string? UnsubscribedSince { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
