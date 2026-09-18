using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateAudienceContactRequest
{
    /// <summary>
    /// The unique ID for the audience.
    /// </summary>
    [JsonIgnore]
    public required string AudienceId { get; set; }

    /// <summary>
    /// Defines how merge field validation is handled. When set to `ignore_required_checks`, the API does not raise an error if required merge fields are missing from the request. When set to `strict`, the API enforces validation and returns an error if any required merge field is not provided. If this setting is omitted, `strict` is applied by default.
    /// </summary>
    [JsonIgnore]
    public CreateAudienceContactRequestMergeFieldValidationMode? MergeFieldValidationMode { get; set; }

    /// <summary>
    /// Indicates the data processing mode. In `historical` mode, contact data changes do not trigger automations or webhooks. In `live mode`, such changes do trigger them.
    /// </summary>
    [JsonIgnore]
    public CreateAudienceContactRequestDataMode? DataMode { get; set; }

    [JsonPropertyName("email_channel")]
    public CreateAudienceContactRequestEmailChannel? EmailChannel { get; set; }

    /// <summary>
    /// The contact's detected language.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// A dictionary of merge fields where the keys are the merge tags. See the [Merge Fields documentation](https://mailchimp.com/developer/marketing/docs/merge-fields/#structure) for more about the structure.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public Dictionary<
        string,
        OneOf<CreateAudienceContactRequestMergeFieldsValueAddr1, string, double>
    >? MergeFields { get; set; }

    [JsonPropertyName("sms_channel")]
    public CreateAudienceContactRequestSmsChannel? SmsChannel { get; set; }

    /// <summary>
    /// An array of tags to add to the contact. Accepts tag name strings or objects with name and status. This operation is append-only; existing tags will be preserved, and only new tags from this array will be added.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<OneOf<string, CreateAudienceContactRequestTagsItemName>>? Tags { get; set; }

    /// <summary>
    /// If a contact already exists, update them instead of returning a conflict error. When `true` and a matching contact is found (by email or phone), the existing contact is updated with the provided channel data. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("update_existing")]
    public bool? UpdateExisting { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
