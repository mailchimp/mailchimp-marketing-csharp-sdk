using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Channel settings
/// </summary>
[Serializable]
public record FacebookAdsChannel : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Is this for facebook audience
    /// </summary>
    [JsonPropertyName("fb_placement_audience")]
    public bool? FbPlacementAudience { get; set; }

    /// <summary>
    /// Is this for facebook feed
    /// </summary>
    [JsonPropertyName("fb_placement_feed")]
    public bool? FbPlacementFeed { get; set; }

    /// <summary>
    /// Is this for instagram feed
    /// </summary>
    [JsonPropertyName("ig_placement_feed")]
    public bool? IgPlacementFeed { get; set; }

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
