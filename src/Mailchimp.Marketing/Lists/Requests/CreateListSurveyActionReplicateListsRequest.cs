using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateListSurveyActionReplicateListsRequest
{
    /// <summary>
    /// The unique ID for the list.
    /// </summary>
    [JsonIgnore]
    public required string ListIdPathParam { get; set; }

    /// <summary>
    /// The ID of the survey.
    /// </summary>
    [JsonIgnore]
    public required string SurveyId { get; set; }

    /// <summary>
    /// The title for the replicated survey.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The unique ID of the audience for the replicated survey. Defaults to the source survey audience.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string? ListId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
