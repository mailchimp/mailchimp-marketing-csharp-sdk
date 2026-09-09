using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by use of a particular email client.
/// </summary>
[Serializable]
public record SegmentTypeItemEmailClient : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by use of a particular email client.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemEmailClientField Field { get; set; }

    /// <summary>
    /// The operation to determine whether we select clients that match the value, or clients that do not match the value.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemEmailClientOp Op { get; set; }

    /// <summary>
    /// The name of the email client.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
