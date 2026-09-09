using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A [merge field](https://mailchimp.com/developer/marketing/docs/merge-fields/) for an audience.
/// </summary>
[Serializable]
public record MergeField : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<MergeFieldLinksItem>? Links { get; set; }

    /// <summary>
    /// The default value for the merge field if `null`.
    /// </summary>
    [JsonPropertyName("default_value")]
    public string? DefaultValue { get; set; }

    /// <summary>
    /// The order that the merge field displays on the list signup form.
    /// </summary>
    [JsonPropertyName("display_order")]
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Extra text to help the subscriber fill out the form.
    /// </summary>
    [JsonPropertyName("help_text")]
    public string? HelpText { get; set; }

    /// <summary>
    /// The ID that identifies this merge field's audience'.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <summary>
    /// The maximum number of merge fields this audience can hold. The limit is determined by the account's plan. Returned on POST responses only. Subtract `total_items` from this value to derive the remaining capacity.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("merge_field_limit")]
    public int? MergeFieldLimit { get; set; }

    /// <summary>
    /// An unchanging id for the merge field.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("merge_id")]
    public int? MergeId { get; set; }

    /// <summary>
    /// The name of the merge field (audience field).
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Extra options for some merge field types.
    /// </summary>
    [JsonPropertyName("options")]
    public MergeFieldOptions? Options { get; set; }

    /// <summary>
    /// Whether the merge field is displayed on the signup form.
    /// </summary>
    [JsonPropertyName("public")]
    public bool? Public { get; set; }

    /// <summary>
    /// The boolean value if the merge field is required.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The merge tag used for Mailchimp campaigns and [adding contact information](https://mailchimp.com/developer/marketing/docs/merge-fields/#add-merge-data-to-contacts).
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// The total number of merge fields on the audience after this field was created. Returned on POST responses only.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_items")]
    public int? TotalItems { get; set; }

    /// <summary>
    /// The [type](https://mailchimp.com/developer/marketing/docs/merge-fields/#structure) for the merge field.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("type")]
    public MergeFieldType? Type { get; set; }

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
