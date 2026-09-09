using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The days of the week to send a daily RSS Campaign.
/// </summary>
[Serializable]
public record CampaignRssOptsScheduleDailySend : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Sends the daily RSS Campaign on Fridays.
    /// </summary>
    [JsonPropertyName("friday")]
    public bool? Friday { get; set; }

    /// <summary>
    /// Sends the daily RSS Campaign on Mondays.
    /// </summary>
    [JsonPropertyName("monday")]
    public bool? Monday { get; set; }

    /// <summary>
    /// Sends the daily RSS Campaign on Saturdays.
    /// </summary>
    [JsonPropertyName("saturday")]
    public bool? Saturday { get; set; }

    /// <summary>
    /// Sends the daily RSS Campaign on Sundays.
    /// </summary>
    [JsonPropertyName("sunday")]
    public bool? Sunday { get; set; }

    /// <summary>
    /// Sends the daily RSS Campaign on Thursdays.
    /// </summary>
    [JsonPropertyName("thursday")]
    public bool? Thursday { get; set; }

    /// <summary>
    /// Sends the daily RSS Campaign on Tuesdays.
    /// </summary>
    [JsonPropertyName("tuesday")]
    public bool? Tuesday { get; set; }

    /// <summary>
    /// Sends the daily RSS Campaign on Wednesdays.
    /// </summary>
    [JsonPropertyName("wednesday")]
    public bool? Wednesday { get; set; }

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
