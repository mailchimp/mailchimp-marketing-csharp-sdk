using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Information about the contact.
/// </summary>
[Serializable]
public record GetSurveyResponsReportingResponseContact : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// URL for the contact's avatar or profile image.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// Indicates whether a contact consents to 1:1 messaging.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("consents_to_one_to_one_messaging")]
    public bool? ConsentsToOneToOneMessaging { get; set; }

    /// <summary>
    /// The ID of this contact.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("contact_id")]
    public string? ContactId { get; set; }

    /// <summary>
    /// The contact's email address.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// The MD5 hash of the lowercase version of the list member's email address.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("email_id")]
    public string? EmailId { get; set; }

    /// <summary>
    /// The contact's full name.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("full_name")]
    public string? FullName { get; set; }

    /// <summary>
    /// The contact's sms phone number.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    /// <summary>
    /// The contact's current status.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public GetSurveyResponsReportingResponseContactStatus? Status { get; set; }

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
