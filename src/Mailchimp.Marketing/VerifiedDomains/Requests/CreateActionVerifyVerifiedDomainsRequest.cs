using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateActionVerifyVerifiedDomainsRequest
{
    /// <summary>
    /// The domain name.
    /// </summary>
    [JsonIgnore]
    public required string DomainName { get; set; }

    /// <summary>
    /// The code that was sent to the email address provided when adding a new domain to verify.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
