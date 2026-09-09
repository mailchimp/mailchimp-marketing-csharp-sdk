using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// Segment by interaction with a SurveyMonkey survey.
/// </summary>
[Serializable]
public record SegmentTypeItemSurveyMonkey : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Segment by interaction with a SurveyMonkey survey.
    /// </summary>
    [JsonPropertyName("field")]
    public required SegmentTypeItemSurveyMonkeyField Field { get; set; }

    /// <summary>
    /// The status of the member with regard to the survey.One of the following: has started the survey, has completed the survey, has not started the survey, or has not completed the survey.
    /// </summary>
    [JsonPropertyName("op")]
    public required SegmentTypeItemSurveyMonkeyOp Op { get; set; }

    /// <summary>
    /// The unique ID of the survey monkey survey.
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
