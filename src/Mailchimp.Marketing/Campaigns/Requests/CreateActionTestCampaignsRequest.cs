using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateActionTestCampaignsRequest
{
    /// <summary>
    /// The unique id for the campaign.
    /// </summary>
    [JsonIgnore]
    public required string CampaignId { get; set; }

    /// <summary>
    /// Choose the type of test email to send.
    /// </summary>
    [JsonPropertyName("send_type")]
    public required CreateActionTestCampaignsRequestSendType SendType { get; set; }

    /// <summary>
    /// An array of email addresses to send the test email to.
    /// </summary>
    [JsonPropertyName("test_emails")]
    public IEnumerable<string> TestEmails { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
