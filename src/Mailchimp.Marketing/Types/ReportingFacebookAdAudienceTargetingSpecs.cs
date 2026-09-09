using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ReportingFacebookAdAudienceTargetingSpecs : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("gender")]
    public int? Gender { get; set; }

    [JsonPropertyName("interests")]
    public IEnumerable<ReportingFacebookAdAudienceTargetingSpecsInterestsItem>? Interests { get; set; }

    [JsonPropertyName("locations")]
    public ReportingFacebookAdAudienceTargetingSpecsLocations? Locations { get; set; }

    [JsonPropertyName("max_age")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("min_age")]
    public int? MinAge { get; set; }

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
