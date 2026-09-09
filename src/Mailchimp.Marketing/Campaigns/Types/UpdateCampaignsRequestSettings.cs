using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The settings for your campaign, including subject, from name, reply-to address, and more.
/// </summary>
[Serializable]
public record UpdateCampaignsRequestSettings : IJsonOnDeserialized
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
    /// Allows Facebook comments on the campaign (also force-enables the Campaign Archive toolbar). Defaults to `true`.
    /// </summary>
    [JsonPropertyName("fb_comments")]
    public bool? FbComments { get; set; }

    /// <summary>
    /// If the campaign is listed in a folder, the id for that folder.
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string? FolderId { get; set; }

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
    /// The id of the template to use.
    /// </summary>
    [JsonPropertyName("template_id")]
    public int? TemplateId { get; set; }

    /// <summary>
    /// The title of the campaign.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The campaign's custom 'To' name. Typically the first name [audience field](https://mailchimp.com/help/getting-started-with-merge-tags/).
    /// </summary>
    [JsonPropertyName("to_name")]
    public string? ToName { get; set; }

    /// <summary>
    /// Use Mailchimp Conversation feature to manage out-of-office replies.
    /// </summary>
    [JsonPropertyName("use_conversation")]
    public bool? UseConversation { get; set; }

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
