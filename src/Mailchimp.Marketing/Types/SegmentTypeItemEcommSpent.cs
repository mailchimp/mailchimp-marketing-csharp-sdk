using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;
using OneOf;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by amount spent on a single order or across all orders.
/// </summary>
[Serializable]
public record SegmentTypeItemEcommSpent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by amount spent on a single order or across all orders.
    /// </summary>
    [JsonPropertyName("field")]
    public SegmentTypeItemEcommSpentField? Field { get; set; }

    /// <summary>
    /// Members who have spent 'more' or 'less' than then specified value.
    /// </summary>
    [JsonPropertyName("op")]
    public SegmentTypeItemEcommSpentOp? Op { get; set; }

    [JsonPropertyName("value")]
    public OneOf<double, string>? Value { get; set; }

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
