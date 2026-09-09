using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A collection of subscriber lists for this account.
/// </summary>
[Serializable]
public record ListListsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<ListListsResponseLinksItem>? Links { get; set; }

    /// <summary>
    /// Do particular authorization constraints around this collection limit creation of new instances?
    /// </summary>
    [JsonPropertyName("constraints")]
    public ListListsResponseConstraints? Constraints { get; set; }

    /// <summary>
    /// An array of objects, each representing a list.
    /// </summary>
    [JsonPropertyName("lists")]
    public IEnumerable<SubscriberList> Lists { get; set; } =
        new global::System.Collections.Generic.List<SubscriberList>();

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
