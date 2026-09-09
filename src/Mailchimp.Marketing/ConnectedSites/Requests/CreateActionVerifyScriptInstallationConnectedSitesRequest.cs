using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateActionVerifyScriptInstallationConnectedSitesRequest
{
    /// <summary>
    /// The unique identifier for the site.
    /// </summary>
    [JsonIgnore]
    public required string ConnectedSiteId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
