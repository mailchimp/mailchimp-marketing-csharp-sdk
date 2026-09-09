using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about a specific template.
/// </summary>
[Serializable]
public record TemplateInstance : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<TemplateInstanceLinksItem>? Links { get; set; }

    /// <summary>
    /// User templates are not 'deleted,' but rather marked as 'inactive.' Returns whether the template is still active.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// If available, the category the template is listed in.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// How the template's content is put together.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("content_type")]
    public TemplateInstanceContentType? ContentType { get; set; }

    /// <summary>
    /// The login name for template's creator.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// The date and time the template was created in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("date_created")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date and time the template was edited in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("date_edited")]
    public DateTime? DateEdited { get; set; }

    /// <summary>
    /// Whether the template uses the drag and drop editor.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("drag_and_drop")]
    public bool? DragAndDrop { get; set; }

    /// <summary>
    /// The login name who last edited the template.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("edited_by")]
    public string? EditedBy { get; set; }

    /// <summary>
    /// The id of the folder the template is currently in.
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string? FolderId { get; set; }

    /// <summary>
    /// The individual id for the template.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the template.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Whether the template contains media queries to make it responsive.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("responsive")]
    public bool? Responsive { get; set; }

    /// <summary>
    /// The URL used for [template sharing](https://mailchimp.com/help/share-a-template/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("share_url")]
    public string? ShareUrl { get; set; }

    /// <summary>
    /// If available, the URL for a thumbnail of the template.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    /// <summary>
    /// The type of template (user, base, or gallery).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("type")]
    public string? Type { get; set; }

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
