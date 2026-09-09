using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The [merge fields](https://mailchimp.com/developer/marketing/docs/merge-fields/) for an audience.
/// </summary>
[Serializable]
public record ListMergeFieldsListsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListMergeFieldsListsResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// The list id.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// The maximum number of merge fields this audience can hold. The limit is determined by the account's plan. Subtract `total_items` from this value to derive the remaining capacity.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("merge_field_limit")]
    public int? MergeFieldLimit { get; set; }

    /// <summary>
    /// An array of objects, each representing a merge field resource.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public IEnumerable<MergeField>? MergeFields { get; set; }

    /// <summary>
    /// The total number of items matching the query regardless of pagination.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_items")]
    public int? TotalItems { get; set; }

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
