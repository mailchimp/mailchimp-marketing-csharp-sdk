using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// An object describing campaign engagement on Facebook.
/// </summary>
[Serializable]
public record CampaignReportFacebookLikes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of Facebook likes for the campaign.
    /// </summary>
    [JsonPropertyName("facebook_likes")]
    public int? FacebookLikes { get; set; }

    /// <summary>
    /// The number of recipients who liked the campaign on Facebook.
    /// </summary>
    [JsonPropertyName("recipient_likes")]
    public int? RecipientLikes { get; set; }

    /// <summary>
    /// The number of unique likes.
    /// </summary>
    [JsonPropertyName("unique_likes")]
    public int? UniqueLikes { get; set; }

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
