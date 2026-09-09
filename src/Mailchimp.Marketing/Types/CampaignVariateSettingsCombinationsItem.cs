using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CampaignVariateSettingsCombinationsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The index of `variate_settings.contents` used.
    /// </summary>
    [JsonPropertyName("content_description")]
    public int? ContentDescription { get; set; }

    /// <summary>
    /// The index of `variate_settings.from_names` used.
    /// </summary>
    [JsonPropertyName("from_name")]
    public int? FromName { get; set; }

    /// <summary>
    /// Unique ID for the combination.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The number of recipients for this combination.
    /// </summary>
    [JsonPropertyName("recipients")]
    public int? Recipients { get; set; }

    /// <summary>
    /// The index of `variate_settings.reply_to_addresses` used.
    /// </summary>
    [JsonPropertyName("reply_to")]
    public int? ReplyTo { get; set; }

    /// <summary>
    /// The index of `variate_settings.send_times` used.
    /// </summary>
    [JsonPropertyName("send_time")]
    public int? SendTime { get; set; }

    /// <summary>
    /// The index of `variate_settings.subject_lines` used.
    /// </summary>
    [JsonPropertyName("subject_line")]
    public int? SubjectLine { get; set; }

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
