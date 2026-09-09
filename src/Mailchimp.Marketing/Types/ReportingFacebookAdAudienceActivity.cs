using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ReportingFacebookAdAudienceActivity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("clicks")]
    public IEnumerable<ReportingFacebookAdAudienceActivityClicksItem>? Clicks { get; set; }

    [JsonPropertyName("impressions")]
    public IEnumerable<ReportingFacebookAdAudienceActivityImpressionsItem>? Impressions { get; set; }

    [JsonPropertyName("revenue")]
    public IEnumerable<ReportingFacebookAdAudienceActivityRevenueItem>? Revenue { get; set; }

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
