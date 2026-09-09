using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Check if this ad is connected to a facebook page
/// </summary>
[Serializable]
public record FacebookAdsFeedback : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Feedback regarding the audience of this Ad.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Feedback regarding the budget of this Ad.
    /// </summary>
    [JsonPropertyName("budget")]
    public string? Budget { get; set; }

    /// <summary>
    /// Feedback regarding the compliance of this Ad.
    /// </summary>
    [JsonPropertyName("compliance")]
    public string? Compliance { get; set; }

    /// <summary>
    /// Feedback regarding the content of this Ad.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

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
