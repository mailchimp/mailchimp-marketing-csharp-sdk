using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The clicks and visits data from the last five weeks.
/// </summary>
[Serializable]
public record LandingPageReportTimeseriesWeeklyStats : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The total number of clicks in a week.
    /// </summary>
    [JsonPropertyName("clicks")]
    public IEnumerable<LandingPageReportTimeseriesWeeklyStatsClicksItem>? Clicks { get; set; }

    [JsonPropertyName("unique_visits")]
    public IEnumerable<LandingPageReportTimeseriesWeeklyStatsUniqueVisitsItem>? UniqueVisits { get; set; }

    /// <summary>
    /// The total number of visits in a week.
    /// </summary>
    [JsonPropertyName("visits")]
    public IEnumerable<LandingPageReportTimeseriesWeeklyStatsVisitsItem>? Visits { get; set; }

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
