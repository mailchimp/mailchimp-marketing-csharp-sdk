using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteCampaignFoldersRequest
{
    /// <summary>
    /// The unique id for the campaign folder.
    /// </summary>
    [JsonIgnore]
    public required string FolderId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
