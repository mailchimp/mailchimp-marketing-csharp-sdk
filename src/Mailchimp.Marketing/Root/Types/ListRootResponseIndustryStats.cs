using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The [average campaign statistics](https://mailchimp.com/resources/research/email-marketing-benchmarks/?utm_source=mc-api&amp;utm_medium=docs&amp;utm_campaign=apidocs) for all campaigns in the account's specified industry.
/// </summary>
[Serializable]
public record ListRootResponseIndustryStats : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The average bounce rate for all campaigns in the account's specified industry.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("bounce_rate")]
    public double? BounceRate { get; set; }

    /// <summary>
    /// The average unique click rate for all campaigns in the account's specified industry.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    /// <summary>
    /// The average unique open rate for all campaigns in the account's specified industry.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("open_rate")]
    public double? OpenRate { get; set; }

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
