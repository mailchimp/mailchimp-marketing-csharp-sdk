using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Survey respondent details.
/// </summary>
[Serializable]
public record ListSurveyResponsesReportingResponseResponsesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Information about the contact.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("contact")]
    public ListSurveyResponsesReportingResponseResponsesItemContact? Contact { get; set; }

    /// <summary>
    /// If this contact was added to the Mailchimp audience via this survey.
    /// </summary>
    [JsonPropertyName("is_new_contact")]
    public bool? IsNewContact { get; set; }

    /// <summary>
    /// The ID for the survey response.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("response_id")]
    public string? ResponseId { get; set; }

    /// <summary>
    /// The date and time when the survey response was submitted in ISO 8601 format.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("submitted_at")]
    public DateTime? SubmittedAt { get; set; }

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
