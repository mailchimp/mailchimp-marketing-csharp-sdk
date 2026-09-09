using global::System.Text.Json.Serialization;
using Mailchimp.Marketing.Core;

namespace Mailchimp.Marketing;

[Serializable]
public record DeleteTemplateFoldersRequest
{
    /// <summary>
    /// The unique id for the template folder.
    /// </summary>
    [JsonIgnore]
    public required string FolderId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
