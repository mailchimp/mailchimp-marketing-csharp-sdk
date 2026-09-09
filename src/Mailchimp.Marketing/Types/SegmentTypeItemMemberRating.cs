using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by member rating.
/// </summary>
[Serializable]
public record SegmentTypeItemMemberRating : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by member rating.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemMemberRatingField Field { get; set; }

    /// <summary>
    /// Members who have have a rating that is/not exactly a given number or members who have a rating greater/less than a given number.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemMemberRatingOp Op { get; set; }

    [JsonPropertyName("value")]
    public required OneOf<double, string> Value { get; set; }

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
