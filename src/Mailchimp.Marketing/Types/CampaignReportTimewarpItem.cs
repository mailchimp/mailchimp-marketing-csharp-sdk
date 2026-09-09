using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CampaignReportTimewarpItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of bounces.
    /// </summary>
    [JsonPropertyName("bounces")]
    public int? Bounces { get; set; }

    /// <summary>
    /// The number of clicks.
    /// </summary>
    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    /// <summary>
    /// For campaigns sent with timewarp, the time zone group the member is apart of.
    /// </summary>
    [JsonPropertyName("gmt_offset")]
    public int? GmtOffset { get; set; }

    /// <summary>
    /// The date and time of the last click in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// The date and time of the last open in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_open")]
    public DateTime? LastOpen { get; set; }

    /// <summary>
    /// The number of opens.
    /// </summary>
    [JsonPropertyName("opens")]
    public int? Opens { get; set; }

    /// <summary>
    /// The number of unique clicks.
    /// </summary>
    [JsonPropertyName("unique_clicks")]
    public int? UniqueClicks { get; set; }

    /// <summary>
    /// The number of unique opens.
    /// </summary>
    [JsonPropertyName("unique_opens")]
    public int? UniqueOpens { get; set; }

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
