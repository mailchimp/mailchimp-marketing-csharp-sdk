using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record GetSurveyResponsReportingRequest
{
    /// <summary>
    /// The ID of the survey.
    /// </summary>
    [JsonIgnore]
    public required string SurveyId { get; set; }

    /// <summary>
    /// The ID of the survey response.
    /// </summary>
    [JsonIgnore]
    public required string ResponseId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
