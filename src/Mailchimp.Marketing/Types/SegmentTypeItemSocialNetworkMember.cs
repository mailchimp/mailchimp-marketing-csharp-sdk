using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by social network in Social Profiles data.
/// </summary>
[Serializable]
public record SegmentTypeItemSocialNetworkMember : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by social network in Social Profiles data.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemSocialNetworkMemberField Field { get; set; }

    /// <summary>
    /// Members who are/not on a given social network.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemSocialNetworkMemberOp Op { get; set; }

    /// <summary>
    /// The social network to segment against.
    /// </summary>
    [JsonPropertyName("value")]
    public required SegmentTypeItemSocialNetworkMemberValue Value { get; set; }

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
