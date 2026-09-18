using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record PostAudiencesContactsActionsForgetRequest
{
    /// <summary>
    /// The unique ID for the audience.
    /// </summary>
    [JsonIgnore]
    public required string AudienceId { get; set; }

    /// <summary>
    /// The unique id for the contact.
    /// </summary>
    [JsonIgnore]
    public required string ContactId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
