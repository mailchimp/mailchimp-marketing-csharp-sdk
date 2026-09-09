using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

/// <summary>
/// The details of a survey question's report.
/// </summary>
[Serializable]
public record SurveyQuestionReport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The average rating for this range question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("average_rating")]
    public float? AverageRating { get; set; }

    /// <summary>
    /// For email question types, how many are new, known, or unknown contacts.
    /// </summary>
    [JsonPropertyName("contact_counts")]
    public SurveyQuestionReportContactCounts? ContactCounts { get; set; }

    /// <summary>
    /// Whether this survey question has an 'other' option.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("has_other")]
    public bool? HasOther { get; set; }

    /// <summary>
    /// The ID of the survey question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether this survey question is required to answer.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("is_required")]
    public bool? IsRequired { get; set; }

    /// <summary>
    /// A [merge field](https://mailchimp.com/developer/marketing/docs/merge-fields/) for an audience.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("merge_field")]
    public SurveyQuestionReportMergeField? MergeField { get; set; }

    /// <summary>
    /// The answer choices for this question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("options")]
    public IEnumerable<SurveyQuestionReportOptionsItem>? Options { get; set; }

    /// <summary>
    /// Label used for the 'other' option of this survey question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("other_label")]
    public string? OtherLabel { get; set; }

    /// <summary>
    /// Placeholder text for this survey question's answer box.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("placeholder_label")]
    public string? PlaceholderLabel { get; set; }

    /// <summary>
    /// The query of the survey question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// Label for the high end of the range.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("range_high_label")]
    public string? RangeHighLabel { get; set; }

    /// <summary>
    /// Label for the low end of the range.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("range_low_label")]
    public string? RangeLowLabel { get; set; }

    /// <summary>
    /// Whether the subscribe checkbox is shown for this email question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subscribe_checkbox_enabled")]
    public bool? SubscribeCheckboxEnabled { get; set; }

    /// <summary>
    /// Label used for the subscribe checkbox for this email question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("subscribe_checkbox_label")]
    public string? SubscribeCheckboxLabel { get; set; }

    /// <summary>
    /// The unique ID of the survey.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("survey_id")]
    public string? SurveyId { get; set; }

    /// <summary>
    /// The total number of responses to this question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("total_responses")]
    public int? TotalResponses { get; set; }

    /// <summary>
    /// The response type of the survey question.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("type")]
    public SurveyQuestionReportType? Type { get; set; }

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
