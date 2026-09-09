using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Members found for given search term
/// </summary>
[Serializable]
public record ListSearchMembersResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListSearchMembersResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// Exact matches of the provided search query.
    /// </summary>
    [JsonPropertyName("exact_matches")]
    public ListSearchMembersResponseExactMatches? ExactMatches { get; set; }

    /// <summary>
    /// Partial matches of the provided search query.
    /// </summary>
    [JsonPropertyName("full_search")]
    public ListSearchMembersResponseFullSearch? FullSearch { get; set; }

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
