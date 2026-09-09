using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Settings for the campaign including the email subject, from name, and from email address.
/// </summary>
[Serializable]
public record AutomationWorkflowEmailSettings : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether Mailchimp [authenticated](https://mailchimp.com/help/about-email-authentication/) the campaign. Defaults to `true`.
    /// </summary>
    [JsonPropertyName("authenticate")]
    public bool? Authenticate { get; set; }

    /// <summary>
    /// An array of [Facebook](https://mailchimp.com/help/connect-or-disconnect-the-facebook-integration/) page ids to auto-post to.
    /// </summary>
    [JsonPropertyName("auto_fb_post")]
    public IEnumerable<string>? AutoFbPost { get; set; }

    /// <summary>
    /// Automatically append Mailchimp's [default footer](https://mailchimp.com/help/about-campaign-footers/) to the campaign.
    /// </summary>
    [JsonPropertyName("auto_footer")]
    public bool? AutoFooter { get; set; }

    /// <summary>
    /// Automatically tweet a link to the [campaign archive](https://mailchimp.com/help/about-email-campaign-archives-and-pages/) page when the campaign is sent.
    /// </summary>
    [JsonPropertyName("auto_tweet")]
    public bool? AutoTweet { get; set; }

    /// <summary>
    /// Whether the campaign uses the drag-and-drop editor.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("drag_and_drop")]
    public bool? DragAndDrop { get; set; }

    /// <summary>
    /// Allows Facebook comments on the campaign (also force-enables the Campaign Archive toolbar). Defaults to `true`.
    /// </summary>
    [JsonPropertyName("fb_comments")]
    public bool? FbComments { get; set; }

    /// <summary>
    /// The 'from' name on the campaign (not an email address).
    /// </summary>
    [JsonPropertyName("from_name")]
    public string? FromName { get; set; }

    /// <summary>
    /// Automatically inline the CSS included with the campaign content.
    /// </summary>
    [JsonPropertyName("inline_css")]
    public bool? InlineCss { get; set; }

    /// <summary>
    /// The preview text for the campaign.
    /// </summary>
    [JsonPropertyName("preview_text")]
    public string? PreviewText { get; set; }

    /// <summary>
    /// The reply-to email address for the campaign.
    /// </summary>
    [JsonPropertyName("reply_to")]
    public string? ReplyTo { get; set; }

    /// <summary>
    /// The subject line for the campaign.
    /// </summary>
    [JsonPropertyName("subject_line")]
    public string? SubjectLine { get; set; }

    /// <summary>
    /// The id for the template used in this campaign.
    /// </summary>
    [JsonPropertyName("template_id")]
    public int? TemplateId { get; set; }

    /// <summary>
    /// The title of the campaign.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

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
