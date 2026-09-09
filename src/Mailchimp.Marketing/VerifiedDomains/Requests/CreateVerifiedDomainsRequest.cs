using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateVerifiedDomainsRequest
{
    /// <summary>
    /// The e-mail address at the domain you want to verify. This will receive a two-factor challenge to be used in the verify action.
    /// </summary>
    [JsonPropertyName("verification_email")]
    public required string VerificationEmail { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
