using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record CreateActionUnpublishLandingPagesRequest
{
    /// <summary>
    /// The unique id for the page.
    /// </summary>
    [JsonIgnore]
    public required string PageId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
