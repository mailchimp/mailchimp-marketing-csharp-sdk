using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// For email question types, how many are new, known, or unknown contacts.
/// </summary>
[Serializable]
public record SurveyQuestionReportContactCounts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of known contacts that responded to this survey.
    /// </summary>
    [JsonPropertyName("known")]
    public int? Known { get; set; }

    /// <summary>
    /// The number of new contacts that responded to this survey.
    /// </summary>
    [JsonPropertyName("new")]
    public int? New { get; set; }

    /// <summary>
    /// The number of unknown contacts that responded to this survey.
    /// </summary>
    [JsonPropertyName("unknown")]
    public int? Unknown { get; set; }

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
