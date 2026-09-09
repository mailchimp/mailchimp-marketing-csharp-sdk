using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The schedule for sending the RSS Campaign.
/// </summary>
[Serializable]
public record UpdateCampaignsRequestRssOptsSchedule : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The days of the week to send a daily RSS Campaign.
    /// </summary>
    [JsonPropertyName("daily_send")]
    public UpdateCampaignsRequestRssOptsScheduleDailySend? DailySend { get; set; }

    /// <summary>
    /// The hour to send the campaign in local time. Acceptable hours are 0-23. For example, '4' would be 4am in [your account's default time zone](https://mailchimp.com/help/set-account-details/).
    /// </summary>
    [JsonPropertyName("hour")]
    public int? Hour { get; set; }

    /// <summary>
    /// The day of the month to send a monthly RSS Campaign. Acceptable days are 0-31, where '0' is always the last day of a month. Months with fewer than the selected number of days will not have an RSS campaign sent out that day. For example, RSS Campaigns set to send on the 30th will not go out in February.
    /// </summary>
    [JsonPropertyName("monthly_send_date")]
    public double? MonthlySendDate { get; set; }

    /// <summary>
    /// The day of the week to send a weekly RSS Campaign.
    /// </summary>
    [JsonPropertyName("weekly_send_day")]
    public UpdateCampaignsRequestRssOptsScheduleWeeklySendDay? WeeklySendDay { get; set; }

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
