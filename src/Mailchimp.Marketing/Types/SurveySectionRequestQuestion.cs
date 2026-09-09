using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// A survey question. On PATCH, include the question id to update it. Omitting question id creates a new question; it does not delete an existing one. To delete a question, omit its section from the sections array.
/// </summary>
[Serializable]
public record SurveySectionRequestQuestion : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The question ID. On PATCH, include to update an existing question; omit to add a new question.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The question text.
    /// </summary>
    [JsonPropertyName("query")]
    public required string Query { get; set; }

    /// <summary>
    /// The response type of the survey question.
    /// </summary>
    [JsonPropertyName("type")]
    public required SurveySectionRequestQuestionType Type { get; set; }

    /// <summary>
    /// Whether this question is required.
    /// </summary>
    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    /// <summary>
    /// Whether this question has an 'other' option.
    /// </summary>
    [JsonPropertyName("has_other")]
    public bool? HasOther { get; set; }

    /// <summary>
    /// Label for the 'other' option.
    /// </summary>
    [JsonPropertyName("other_label")]
    public string? OtherLabel { get; set; }

    /// <summary>
    /// Label for the low end of a range question.
    /// </summary>
    [JsonPropertyName("range_low_label")]
    public string? RangeLowLabel { get; set; }

    /// <summary>
    /// Label for the high end of a range question.
    /// </summary>
    [JsonPropertyName("range_high_label")]
    public string? RangeHighLabel { get; set; }

    /// <summary>
    /// Low value for a range question.
    /// </summary>
    [JsonPropertyName("range_low_value")]
    public int? RangeLowValue { get; set; }

    /// <summary>
    /// High value for a range question.
    /// </summary>
    [JsonPropertyName("range_high_value")]
    public int? RangeHighValue { get; set; }

    /// <summary>
    /// How a range question is presented.
    /// </summary>
    [JsonPropertyName("range_presentation")]
    public string? RangePresentation { get; set; }

    /// <summary>
    /// Placeholder text for text or email questions.
    /// </summary>
    [JsonPropertyName("placeholder_label")]
    public string? PlaceholderLabel { get; set; }

    /// <summary>
    /// Whether the subscribe checkbox is enabled.
    /// </summary>
    [JsonPropertyName("subscribe_checkbox_enabled")]
    public bool? SubscribeCheckboxEnabled { get; set; }

    /// <summary>
    /// Label for the subscribe checkbox.
    /// </summary>
    [JsonPropertyName("subscribe_checkbox_label")]
    public string? SubscribeCheckboxLabel { get; set; }

    /// <summary>
    /// Whether responses should automatically apply tags.
    /// </summary>
    [JsonPropertyName("should_auto_tag")]
    public bool? ShouldAutoTag { get; set; }

    /// <summary>
    /// Answer options for pickOne, pickMany, or dropdown questions.
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<SurveySectionRequestQuestionOptionsItem>? Options { get; set; }

    /// <summary>
    /// Merge field mapping for contact information questions.
    /// </summary>
    [JsonPropertyName("merge_field")]
    public Dictionary<string, object?>? MergeField { get; set; }

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
