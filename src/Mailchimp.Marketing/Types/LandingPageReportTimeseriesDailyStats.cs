using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The clicks and visits data from the last seven days.
/// </summary>
[Serializable]
public record LandingPageReportTimeseriesDailyStats : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("clicks")]
    public IEnumerable<LandingPageReportTimeseriesDailyStatsClicksItem>? Clicks { get; set; }

    [JsonPropertyName("unique_visits")]
    public IEnumerable<LandingPageReportTimeseriesDailyStatsUniqueVisitsItem>? UniqueVisits { get; set; }

    [JsonPropertyName("visits")]
    public IEnumerable<LandingPageReportTimeseriesDailyStatsVisitsItem>? Visits { get; set; }

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
