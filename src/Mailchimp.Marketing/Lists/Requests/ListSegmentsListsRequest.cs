using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListSegmentsListsRequest
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
    /// Limit results based on segment type.
    /// </summary>
    [JsonIgnore]
    public string? Type { get; set; }

    /// <summary>
    /// Restrict results to segments created after the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? SinceCreatedAt { get; set; }

    /// <summary>
    /// Restrict results to segments created before the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? BeforeCreatedAt { get; set; }

    /// <summary>
    /// Include cleaned members in response
    /// </summary>
    [JsonIgnore]
    public bool? IncludeCleaned { get; set; }

    /// <summary>
    /// Include transactional members in response
    /// </summary>
    [JsonIgnore]
    public bool? IncludeTransactional { get; set; }

    /// <summary>
    /// Include unsubscribed members in response
    /// </summary>
    [JsonIgnore]
    public bool? IncludeUnsubscribed { get; set; }

    /// <summary>
    /// Restrict results to segments update after the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? SinceUpdatedAt { get; set; }

    /// <summary>
    /// Restrict results to segments update before the set time. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? BeforeUpdatedAt { get; set; }

    /// <summary>
    /// Exclude results based on segment type. For example, use `exclude_type=static` to exclude tags from the response.
    /// </summary>
    [JsonIgnore]
    public ListSegmentsListsRequestExcludeType? ExcludeType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
