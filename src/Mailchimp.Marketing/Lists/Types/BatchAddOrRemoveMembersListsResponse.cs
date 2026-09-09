using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Batch add/remove List members to/from static segment
/// </summary>
[Serializable]
public record BatchAddOrRemoveMembersListsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<BatchAddOrRemoveMembersListsResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("error_count")]
    public int? ErrorCount { get; set; }

    /// <summary>
    /// An array of objects, each representing an array of email addresses that could not be added to the segment or removed and an error message providing more details.
    /// </summary>
    [JsonPropertyName("errors")]
    public IEnumerable<BatchAddOrRemoveMembersListsResponseErrorsItem>? Errors { get; set; }

    /// <summary>
    /// An array of objects, each representing a new member that was added to the static segment.
    /// </summary>
    [JsonPropertyName("members_added")]
    public IEnumerable<ListsPost>? MembersAdded { get; set; }

    /// <summary>
    /// An array of objects, each representing an existing list member that got deleted from the static segment.
    /// </summary>
    [JsonPropertyName("members_removed")]
    public IEnumerable<ListsPost>? MembersRemoved { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("total_added")]
    public int? TotalAdded { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("total_removed")]
    public int? TotalRemoved { get; set; }

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
