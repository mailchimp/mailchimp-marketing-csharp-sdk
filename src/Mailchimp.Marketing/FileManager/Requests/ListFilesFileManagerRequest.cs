using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListFilesFileManagerRequest
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
    /// The file type for the File Manager file.
    /// </summary>
    [JsonIgnore]
    public string? Type { get; set; }

    /// <summary>
    /// The Mailchimp account user who created the File Manager file.
    /// </summary>
    [JsonIgnore]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Restrict the response to files created before the set date. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? BeforeCreatedAt { get; set; }

    /// <summary>
    /// Restrict the response to files created after the set date. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? SinceCreatedAt { get; set; }

    /// <summary>
    /// Returns files sorted by the specified field.
    /// </summary>
    [JsonIgnore]
    public ListFilesFileManagerRequestSortField? SortField { get; set; }

    /// <summary>
    /// Determines the order direction for sorted results.
    /// </summary>
    [JsonIgnore]
    public ListFilesFileManagerRequestSortDir? SortDir { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
