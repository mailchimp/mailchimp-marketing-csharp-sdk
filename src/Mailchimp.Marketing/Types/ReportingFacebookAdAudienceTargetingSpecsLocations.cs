using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ReportingFacebookAdAudienceTargetingSpecsLocations : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("cities")]
    public IEnumerable<string>? Cities { get; set; }

    [JsonPropertyName("countries")]
    public IEnumerable<string>? Countries { get; set; }

    [JsonPropertyName("regions")]
    public IEnumerable<string>? Regions { get; set; }

    [JsonPropertyName("zips")]
    public IEnumerable<string>? Zips { get; set; }

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
