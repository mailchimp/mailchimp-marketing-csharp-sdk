using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// The settings specific to A/B test campaigns.
/// </summary>
[Serializable]
public record CreateCampaignsRequestVariateSettings : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The possible from names. The number of from_names provided must match the number of reply_to_addresses. If no from_names are provided, settings.from_name will be used.
    /// </summary>
    [JsonPropertyName("from_names")]
    public IEnumerable<string>? FromNames { get; set; }

    /// <summary>
    /// The possible reply-to addresses. The number of reply_to_addresses provided must match the number of from_names. If no reply_to_addresses are provided, settings.reply_to will be used.
    /// </summary>
    [JsonPropertyName("reply_to_addresses")]
    public IEnumerable<string>? ReplyToAddresses { get; set; }

    /// <summary>
    /// The possible send times to test. The times provided should be in the format YYYY-MM-DD HH:MM:SS or ISO 8601 date-time format. If send_times are provided to test, the test_size will be set to 100% and winner_criteria will be ignored.
    /// </summary>
    [JsonPropertyName("send_times")]
    public IEnumerable<OneOf<DateTime, string>>? SendTimes { get; set; }

    /// <summary>
    /// The possible subject lines to test. If no subject lines are provided, settings.subject_line will be used.
    /// </summary>
    [JsonPropertyName("subject_lines")]
    public IEnumerable<string>? SubjectLines { get; set; }

    /// <summary>
    /// The percentage of recipients to send the test combinations to, must be a value between 10 and 100.
    /// </summary>
    [JsonPropertyName("test_size")]
    public int? TestSize { get; set; }

    /// <summary>
    /// The number of minutes to wait before choosing the winning campaign. The value of wait_time must be greater than 0 and in whole hours, specified in minutes.
    /// </summary>
    [JsonPropertyName("wait_time")]
    public int? WaitTime { get; set; }

    /// <summary>
    /// The combination that performs the best. This may be determined automatically by click rate, open rate, or total revenue -- or you may choose manually based on the reporting data you find the most valuable. For Multivariate Campaigns testing send_time, winner_criteria is ignored. For Multivariate Campaigns with 'manual' as the winner_criteria, the winner must be chosen in the Mailchimp web application.
    /// </summary>
    [JsonPropertyName("winner_criteria")]
    public required CreateCampaignsRequestVariateSettingsWinnerCriteria WinnerCriteria { get; set; }

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
