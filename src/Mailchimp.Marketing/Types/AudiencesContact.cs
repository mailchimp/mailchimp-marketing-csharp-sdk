using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// An instance of a contact.
/// </summary>
[Serializable]
public record AudiencesContact : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique ID for the audience.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("audience_id")]
    public string? AudienceId { get; set; }

    /// <summary>
    /// The date that the contact was created.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("email_channel")]
    public AudiencesContactEmailChannel? EmailChannel { get; set; }

    /// <summary>
    /// The unique ID for the contact.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The contact's detected language. Empty string when no language has been detected or set.
    /// </summary>
    [JsonPropertyName("language")]
    public AudiencesContactLanguage? Language { get; set; }

    /// <summary>
    /// The date that the contact was last updated.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_updated_at")]
    public DateTime? LastUpdatedAt { get; set; }

    /// <summary>
    /// A dictionary of merge fields where the keys are the merge tags. See the [Merge Fields documentation](https://mailchimp.com/developer/marketing/docs/merge-fields/#structure) for more about the structure.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public Dictionary<
        string,
        OneOf<AudiencesContactMergeFieldsValueAddr1, string, double>
    >? MergeFields { get; set; }

    [JsonPropertyName("sms_channel")]
    public AudiencesContactSmsChannel? SmsChannel { get; set; }

    /// <summary>
    /// The source from which the parent's entity was created.
    /// </summary>
    [JsonPropertyName("source")]
    public AudiencesContactSource? Source { get; set; }

    /// <summary>
    /// The status of a contact.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public AudiencesContactStatus? Status { get; set; }

    /// <summary>
    /// The tags assigned to this contact.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

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
