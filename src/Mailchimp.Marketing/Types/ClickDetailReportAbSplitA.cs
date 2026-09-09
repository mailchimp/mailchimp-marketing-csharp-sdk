using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Stats for Group A.
/// </summary>
[Serializable]
public record ClickDetailReportAbSplitA : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The percentage of total clicks for Group A.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("click_percentage_a")]
    public double? ClickPercentageA { get; set; }

    /// <summary>
    /// The total number of clicks for Group A.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_clicks_a")]
    public int? TotalClicksA { get; set; }

    /// <summary>
    /// The percentage of unique clicks for Group A.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_click_percentage_a")]
    public double? UniqueClickPercentageA { get; set; }

    /// <summary>
    /// The number of unique clicks for Group A.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_clicks_a")]
    public int? UniqueClicksA { get; set; }

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
