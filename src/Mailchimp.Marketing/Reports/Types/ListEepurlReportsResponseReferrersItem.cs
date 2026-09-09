using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A single instance of a campaign referral.
/// </summary>
[Serializable]
public record ListEepurlReportsResponseReferrersItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of clicks a single referrer generated.
    /// </summary>
    [JsonPropertyName("clicks")]
    public int? Clicks { get; set; }

    /// <summary>
    /// The timestamp for the first click from this referrer.
    /// </summary>
    [JsonPropertyName("first_click")]
    public DateTime? FirstClick { get; set; }

    /// <summary>
    /// The timestamp for the last click from this referrer.
    /// </summary>
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// A referrer (truncated to 100 bytes).
    /// </summary>
    [JsonPropertyName("referrer")]
    public string? Referrer { get; set; }

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
