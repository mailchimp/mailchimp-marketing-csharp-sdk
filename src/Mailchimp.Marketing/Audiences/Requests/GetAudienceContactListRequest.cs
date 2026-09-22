using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record GetAudienceContactListRequest
{
    /// <summary>
    /// The unique ID for the audience.
    /// </summary>
    [JsonIgnore]
    public required string AudienceId { get; set; }

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
    /// Paginate through a collection of records by setting the `cursor` parameter to a `next_cursor` attribute returned by a previous request. Default value fetches the first "page" of results.
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// Restricts the response to contacts created at or before the specified time (inclusive). Uses ISO 8601 format: 2025-04-23T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedBefore { get; set; }

    /// <summary>
    /// Restricts the response to contacts created after the specified time (exclusive). Uses ISO 8601 format: 2025-04-23T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedSince { get; set; }

    /// <summary>
    /// Restricts the response to contacts updated at or before the specified time (inclusive). Uses ISO 8601 format: 2025-04-23T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedBefore { get; set; }

    /// <summary>
    /// Restricts the response to contacts updated after the specified time (exclusive). Uses ISO 8601 format: 2025-04-23T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedSince { get; set; }

    /// <summary>
    /// Specifies the field to sort the returned contacts by.
    /// </summary>
    [JsonIgnore]
    public GetAudienceContactListRequestSortField? SortField { get; set; }

    /// <summary>
    /// Determines the order direction for sorted results.
    /// </summary>
    [JsonIgnore]
    public GetAudienceContactListRequestSortDir? SortDir { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
