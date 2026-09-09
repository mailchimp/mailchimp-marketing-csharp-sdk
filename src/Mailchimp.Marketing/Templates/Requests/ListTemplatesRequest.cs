using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListTemplatesRequest
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
    /// The Mailchimp account user who created the template.
    /// </summary>
    [JsonIgnore]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Restrict the response to templates created after the set date. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? SinceDateCreated { get; set; }

    /// <summary>
    /// Restrict the response to templates created before the set date. Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [JsonIgnore]
    public string? BeforeDateCreated { get; set; }

    /// <summary>
    /// Limit results based on template type.
    /// </summary>
    [JsonIgnore]
    public string? Type { get; set; }

    /// <summary>
    /// Limit results based on category.
    /// </summary>
    [JsonIgnore]
    public string? Category { get; set; }

    /// <summary>
    /// The unique folder id.
    /// </summary>
    [JsonIgnore]
    public string? FolderId { get; set; }

    /// <summary>
    /// Returns user templates sorted by the specified field.
    /// </summary>
    [JsonIgnore]
    public ListTemplatesRequestSortField? SortField { get; set; }

    /// <summary>
    /// Limit results based on how the template's content is put together. Only templates of type `user` can be filtered by `content_type`. If you want to retrieve saved templates created with the legacy email editor, then filter `content_type` to `template`. If you'd rather pull your saved templates for the new editor, filter to `multichannel`. For code your own templates, filter to `html`.
    /// </summary>
    [JsonIgnore]
    public ListTemplatesRequestContentType? ContentType { get; set; }

    /// <summary>
    /// Determines the order direction for sorted results.
    /// </summary>
    [JsonIgnore]
    public ListTemplatesRequestSortDir? SortDir { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
