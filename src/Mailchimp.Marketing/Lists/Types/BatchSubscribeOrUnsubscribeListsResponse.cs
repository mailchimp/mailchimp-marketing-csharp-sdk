using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Batch update list members.
/// </summary>
[Serializable]
public record BatchSubscribeOrUnsubscribeListsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<BatchSubscribeOrUnsubscribeListsResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("error_count")]
    public int? ErrorCount { get; set; }

    /// <summary>
    /// An array of objects, each representing an email address that could not be added to the list or updated and an error message providing more details.
    /// </summary>
    [JsonPropertyName("errors")]
    public IEnumerable<BatchSubscribeOrUnsubscribeListsResponseErrorsItem>? Errors { get; set; }

    /// <summary>
    /// An array of objects, each representing a new member that was added to the list.
    /// </summary>
    [JsonPropertyName("new_members")]
    public IEnumerable<ListsPost>? NewMembers { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("total_created")]
    public int? TotalCreated { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("total_updated")]
    public int? TotalUpdated { get; set; }

    /// <summary>
    /// An array of objects, each representing an existing list member whose subscription status was updated.
    /// </summary>
    [JsonPropertyName("updated_members")]
    public IEnumerable<ListsPost>? UpdatedMembers { get; set; }

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
