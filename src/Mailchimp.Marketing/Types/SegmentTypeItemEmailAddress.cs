using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by email address.
/// </summary>
[Serializable]
public record SegmentTypeItemEmailAddress : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segmenting based off of a subscriber's email address.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemEmailAddressField Field { get; set; }

    /// <summary>
    /// Whether the email address is/not exactly, contains/doesn't contain, starts/ends with a string.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemEmailAddressOp Op { get; set; }

    /// <summary>
    /// The value to compare the email against.
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
