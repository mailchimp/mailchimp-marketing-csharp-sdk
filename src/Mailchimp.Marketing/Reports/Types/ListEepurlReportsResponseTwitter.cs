using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A summary of Twitter activity for a campaign.
/// </summary>
[Serializable]
public record ListEepurlReportsResponseTwitter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The day and time of the first recorded tweet with a link to the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("first_tweet")]
    public string? FirstTweet { get; set; }

    /// <summary>
    /// The day and time of the last recorded tweet with a link to the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("last_tweet")]
    public string? LastTweet { get; set; }

    /// <summary>
    /// The number of retweets that include a link to the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("retweets")]
    public int? Retweets { get; set; }

    /// <summary>
    /// A summary of tweets that include a link to the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("statuses")]
    public IEnumerable<ListEepurlReportsResponseTwitterStatusesItem>? Statuses { get; set; }

    /// <summary>
    /// The number of tweets including a link to the campaign.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("tweets")]
    public int? Tweets { get; set; }

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
