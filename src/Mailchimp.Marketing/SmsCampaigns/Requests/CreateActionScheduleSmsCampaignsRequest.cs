using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateActionScheduleSmsCampaignsRequest
{
    /// <summary>
    /// The unique id for the SMS campaign.
    /// </summary>
    [JsonIgnore]
    public required string SmsCampaignId { get; set; }

    /// <summary>
    /// The UTC date and time to schedule the campaign.
    /// </summary>
    [JsonPropertyName("schedule_time")]
    public required DateTime ScheduleTime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
