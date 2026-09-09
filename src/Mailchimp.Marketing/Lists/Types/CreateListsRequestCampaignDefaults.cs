using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// [Default values for campaigns](https://mailchimp.com/help/edit-your-emails-subject-preview-text-from-name-or-from-email-address/) created for this list.
/// </summary>
[Serializable]
public record CreateListsRequestCampaignDefaults : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The default from email for campaigns sent to this list.
    /// </summary>
    [JsonPropertyName("from_email")]
    public required string FromEmail { get; set; }

    /// <summary>
    /// The default from name for campaigns sent to this list.
    /// </summary>
    [JsonPropertyName("from_name")]
    public required string FromName { get; set; }

    /// <summary>
    /// The default language for this lists's forms.
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; set; }

    /// <summary>
    /// The default subject line for campaigns sent to this list.
    /// </summary>
    [JsonPropertyName("subject")]
    public required string Subject { get; set; }

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
