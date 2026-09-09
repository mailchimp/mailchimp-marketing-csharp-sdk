using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An object describing the bounce summary for the campaign.
/// </summary>
[Serializable]
public record CampaignReportBounces : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The total number of hard bounced email addresses.
    /// </summary>
    [JsonPropertyName("hard_bounces")]
    public int? HardBounces { get; set; }

    /// <summary>
    /// The total number of soft bounced email addresses.
    /// </summary>
    [JsonPropertyName("soft_bounces")]
    public int? SoftBounces { get; set; }

    /// <summary>
    /// The total number of addresses that were syntax-related bounces.
    /// </summary>
    [JsonPropertyName("syntax_errors")]
    public int? SyntaxErrors { get; set; }

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
