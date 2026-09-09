using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A summary of the click-throughs on the campaign's URL.
/// </summary>
[Serializable]
public record ListEepurlReportsResponseClicks : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The total number of clicks to the campaign's URL.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    /// <summary>
    /// The timestamp for the first click to the URL.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("first_click")]
    public DateTime? FirstClick { get; set; }

    /// <summary>
    /// The timestamp for the last click to the URL.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// A summary of the top click locations.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("locations")]
    public IEnumerable<ListEepurlReportsResponseClicksLocationsItem>? Locations { get; set; }

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
