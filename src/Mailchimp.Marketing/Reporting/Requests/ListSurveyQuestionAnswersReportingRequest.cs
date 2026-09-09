using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record ListSurveyQuestionAnswersReportingRequest
{
    /// <summary>
    /// The ID of the survey.
    /// </summary>
    [JsonIgnore]
    public required string SurveyId { get; set; }

    /// <summary>
    /// The ID of the survey question.
    /// </summary>
    [JsonIgnore]
    public required string QuestionId { get; set; }

    /// <summary>
    /// A comma-separated list of fields to return. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Fields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// A comma-separated list of fields to exclude. Reference parameters of sub-objects with dot notation.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ExcludeFields { get; set; } =
        new global::System.Collections.Generic.List<string>();

    /// <summary>
    /// Filter survey responses by familiarity of the respondents.
    /// </summary>
    [JsonIgnore]
    public ListSurveyQuestionAnswersReportingRequestRespondentFamiliarityIs? RespondentFamiliarityIs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
