using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record GetSegmentListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListId { get; set; }

    /// <summary>
    /// The unique id for the segment.
    /// </summary>
    [JsonIgnore]
    public required string SegmentId { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
