using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Stats for Group B.
/// </summary>
[Serializable]
public record ClickDetailReportAbSplitB : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The percentage of total clicks for Group B.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("click_percentage_b")]
    public double? ClickPercentageB { get; set; }

    /// <summary>
    /// The total number of clicks for Group B.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_clicks_b")]
    public int? TotalClicksB { get; set; }

    /// <summary>
    /// The percentage of unique clicks for Group B.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_click_percentage_b")]
    public double? UniqueClickPercentageB { get; set; }

    /// <summary>
    /// The number of unique clicks for Group B.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("unique_clicks_b")]
    public int? UniqueClicksB { get; set; }

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
