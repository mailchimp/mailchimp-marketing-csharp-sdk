using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// General stats about different groups of an A/B Split campaign. Does not return information about Multivariate Campaigns.
/// </summary>
[Serializable]
public record CampaignReportAbSplit : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Stats for Campaign A.
    /// </summary>
    [JsonPropertyName("a")]
    public CampaignReportAbSplitA? A { get; set; }

    /// <summary>
    /// Stats for Campaign B.
    /// </summary>
    [JsonPropertyName("b")]
    public CampaignReportAbSplitB? B { get; set; }

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
