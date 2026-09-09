using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record FacebookAd : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The date and time the outreach was canceled in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("canceled_at")]
    public DateTime? CanceledAt { get; set; }

    /// <summary>
    /// The date and time the outreach was created in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// If this outreach targets a segment of your audience.
    /// </summary>
    [JsonPropertyName("has_segment")]
    public bool? HasSegment { get; set; }

    /// <summary>
    /// Unique ID of an Outreach.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Title or name of an Outreach.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The date and time the outreach was (or will be) published in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("published_time")]
    public DateTime? PublishedTime { get; set; }

    /// <summary>
    /// High level audience information for who the outreach targets.
    /// </summary>
    [JsonPropertyName("recipients")]
    public FacebookAdRecipients? Recipients { get; set; }

    /// <summary>
    /// High level reporting stats for an outreach.
    /// </summary>
    [JsonPropertyName("report_summary")]
    public FacebookAdReportSummary? ReportSummary { get; set; }

    /// <summary>
    /// Outreach report availability. Note: This property is hotly debated in what it _should_ convey. See [MCP-1371](https://jira.mailchimp.com/browse/MCP-1371) for more context.
    /// </summary>
    [JsonPropertyName("show_report")]
    public bool? ShowReport { get; set; }

    /// <summary>
    /// The date and time the outreach was started in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The status of this outreach.
    /// </summary>
    [JsonPropertyName("status")]
    public FacebookAdStatus? Status { get; set; }

    /// <summary>
    /// The type of outreach this object is.
    /// </summary>
    [JsonPropertyName("type")]
    public FacebookAdType? Type { get; set; }

    /// <summary>
    /// The date and time the outreach was last updated in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The ID used in the Mailchimp web application. For example, for a `regular` outreach, you can view this campaign in your Mailchimp account at `https://{dc}.admin.mailchimp.com/campaigns/show/?id={web_id}`.
    /// </summary>
    [JsonPropertyName("web_id")]
    public int? WebId { get; set; }

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
