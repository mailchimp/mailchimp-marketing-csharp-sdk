using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An object describing the forwards and forward activity for the campaign.
/// </summary>
[Serializable]
public record CampaignReportForwards : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// How many times the campaign has been forwarded.
    /// </summary>
    [JsonPropertyName("forwards_count")]
    public int? ForwardsCount { get; set; }

    /// <summary>
    /// How many times the forwarded campaign has been opened.
    /// </summary>
    [JsonPropertyName("forwards_opens")]
    public int? ForwardsOpens { get; set; }

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
