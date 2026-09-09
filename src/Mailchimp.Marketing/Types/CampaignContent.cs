using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The HTML and plain-text content for a campaign.
/// </summary>
[Serializable]
public record CampaignContent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("_links")]
    public IEnumerable<CampaignContentLinksItem>? Links { get; set; }

    /// <summary>
    /// The Archive HTML for the campaign.
    /// </summary>
    [JsonPropertyName("archive_html")]
    public string? ArchiveHtml { get; set; }

    /// <summary>
    /// The raw HTML for the campaign.
    /// </summary>
    [JsonPropertyName("html")]
    public string? Html { get; set; }

    /// <summary>
    /// The plain-text portion of the campaign. If left unspecified, we'll generate this automatically.
    /// </summary>
    [JsonPropertyName("plain_text")]
    public string? PlainText { get; set; }

    /// <summary>
    /// Content options for multivariate campaigns.
    /// </summary>
    [JsonPropertyName("variate_contents")]
    public IEnumerable<CampaignContentVariateContentsItem>? VariateContents { get; set; }

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
