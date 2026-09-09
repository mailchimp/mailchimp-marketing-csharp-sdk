using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by purchases in specific items or categories.
/// </summary>
[Serializable]
public record SegmentTypeItemEcommCategory : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by purchases in specific items or categories.
    /// </summary>
    [JsonPropertyName("field")]
    public SegmentTypeItemEcommCategoryField? Field { get; set; }

    /// <summary>
    /// A member who has purchased from a category/specific item that is/is not a specific name, where the category/item name contains/doesn't contain a specific phrase or string, or a category/item name that starts/ends with a string.
    /// </summary>
    [JsonPropertyName("op")]
    public SegmentTypeItemEcommCategoryOp? Op { get; set; }

    /// <summary>
    /// The ecommerce category/item information.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

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
