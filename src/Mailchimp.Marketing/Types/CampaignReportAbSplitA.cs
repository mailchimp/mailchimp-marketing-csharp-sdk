using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Stats for Campaign A.
/// </summary>
[Serializable]
public record CampaignReportAbSplitA : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Abuse reports for Campaign A.
    /// </summary>
    [JsonPropertyName("abuse_reports")]
    public int? AbuseReports { get; set; }

    /// <summary>
    /// Bounces for Campaign A.
    /// </summary>
    [JsonPropertyName("bounces")]
    public int? Bounces { get; set; }

    /// <summary>
    /// Forwards for Campaign A.
    /// </summary>
    [JsonPropertyName("forwards")]
    public int? Forwards { get; set; }

    /// <summary>
    /// Opens from forwards for Campaign A.
    /// </summary>
    [JsonPropertyName("forwards_opens")]
    public int? ForwardsOpens { get; set; }

    /// <summary>
    /// The last open for Campaign A.
    /// </summary>
    [JsonPropertyName("last_open")]
    public string? LastOpen { get; set; }

    /// <summary>
    /// Opens for Campaign A.
    /// </summary>
    [JsonPropertyName("opens")]
    public int? Opens { get; set; }

    /// <summary>
    /// Recipient Clicks for Campaign A.
    /// </summary>
    [JsonPropertyName("recipient_clicks")]
    public int? RecipientClicks { get; set; }

    /// <summary>
    /// Unique opens for Campaign A.
    /// </summary>
    [JsonPropertyName("unique_opens")]
    public int? UniqueOpens { get; set; }

    /// <summary>
    /// Unsubscribes for Campaign A.
    /// </summary>
    [JsonPropertyName("unsubs")]
    public int? Unsubs { get; set; }

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
