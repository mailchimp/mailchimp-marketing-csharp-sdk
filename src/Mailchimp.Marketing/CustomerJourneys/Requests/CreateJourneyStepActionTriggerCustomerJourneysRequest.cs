using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateJourneyStepActionTriggerCustomerJourneysRequest
{
    /// <summary>
    /// The id for the flow.
    /// </summary>
    [JsonIgnore]
    public required int JourneyId { get; set; }

    /// <summary>
    /// The id for the Step.
    /// </summary>
    [JsonIgnore]
    public required int StepId { get; set; }

    /// <summary>
    /// The list member's email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public required string EmailAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
