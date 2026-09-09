using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateConnectedSitesRequest
{
    /// <summary>
    /// The connected site domain.
    /// </summary>
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    /// <summary>
    /// The unique identifier for the site.
    /// </summary>
    [JsonPropertyName("foreign_id")]
    public required string ForeignId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
