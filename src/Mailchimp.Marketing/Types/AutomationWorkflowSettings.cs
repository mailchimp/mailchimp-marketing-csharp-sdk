using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The settings for the Automation workflow.
/// </summary>
[Serializable]
public record AutomationWorkflowSettings : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether Mailchimp [authenticated](https://mailchimp.com/help/about-email-authentication/) the Automation. Defaults to `true`.
    /// </summary>
    [JsonPropertyName("authenticate")]
    public bool? Authenticate { get; set; }

    /// <summary>
    /// Whether to automatically append Mailchimp's [default footer](https://mailchimp.com/help/about-campaign-footers/) to the Automation.
    /// </summary>
    [JsonPropertyName("auto_footer")]
    public bool? AutoFooter { get; set; }

    /// <summary>
    /// The 'from' name for the Automation (not an email address).
    /// </summary>
    [JsonPropertyName("from_name")]
    public string? FromName { get; set; }

    /// <summary>
    /// Whether to automatically inline the CSS included with the Automation content.
    /// </summary>
    [JsonPropertyName("inline_css")]
    public bool? InlineCss { get; set; }

    /// <summary>
    /// The reply-to email address for the Automation.
    /// </summary>
    [JsonPropertyName("reply_to")]
    public string? ReplyTo { get; set; }

    /// <summary>
    /// The title of the Automation.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The Automation's custom 'To' name, typically the first name [audience field](https://mailchimp.com/help/getting-started-with-merge-tags/).
    /// </summary>
    [JsonPropertyName("to_name")]
    public string? ToName { get; set; }

    /// <summary>
    /// Whether to use Mailchimp Conversation feature to manage replies
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
