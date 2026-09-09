using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by whether someone has purchased anything.
/// </summary>
[Serializable]
public record SegmentTypeItemEcommPurchased : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by whether someone has purchased anything.
    /// </summary>
    [JsonPropertyName("field")]
    public SegmentTypeItemEcommPurchasedField? Field { get; set; }

    /// <summary>
    /// Members who have have ('member') or have not ('notmember') purchased.
    /// </summary>
    [JsonPropertyName("op")]
    public SegmentTypeItemEcommPurchasedOp? Op { get; set; }

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
