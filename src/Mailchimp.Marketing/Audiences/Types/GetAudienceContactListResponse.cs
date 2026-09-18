using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An array of objects, each representing a contact record.
/// </summary>
[Serializable]
public record GetAudienceContactListResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// An array of objects, each representing a contact record.
    /// </summary>
    [JsonPropertyName("contacts")]
    public IEnumerable<AudiencesContact>? Contacts { get; set; }

    /// <summary>
    /// A cursor pointing to the last item on this page of the collection. Paginate through a collection of records by setting the `cursor` parameter on a subsequent request to this value.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; set; }

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<GetAudienceContactListResponseLinksItem>? Links { get; set; }

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
