using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A breakdown of clicks by different groups of an A/B Split campaign. Does not return information about Multivariate Campaigns.
/// </summary>
[Serializable]
public record ClickDetailReportAbSplit : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Stats for Group A.
    /// </summary>
    [JsonPropertyName("a")]
    public ClickDetailReportAbSplitA? A { get; set; }

    /// <summary>
    /// Stats for Group B.
    /// </summary>
    [JsonPropertyName("b")]
    public ClickDetailReportAbSplitB? B { get; set; }

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
