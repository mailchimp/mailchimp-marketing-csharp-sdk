using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A survey section. On PATCH, include the section id to update it; omit the section from the sections array to delete it (and any question it contains).
/// </summary>
[Serializable]
public record SurveySectionRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The section ID. On PATCH, include to update an existing section; omit to add a new section.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The section type.
    /// </summary>
    [JsonPropertyName("type")]
    public required SurveySectionRequestType Type { get; set; }

    /// <summary>
    /// Rich text content for introduction or context sections.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Additional section options.
    /// </summary>
    [JsonPropertyName("options")]
    public Dictionary<string, object?>? Options { get; set; }

    /// <summary>
    /// A survey question. On PATCH, include the question id to update it. Omitting question id creates a new question; it does not delete an existing one. To delete a question, omit its section from the sections array.
    /// </summary>
    [JsonPropertyName("question")]
    public SurveySectionRequestQuestion? Question { get; set; }

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
